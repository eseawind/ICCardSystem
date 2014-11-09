using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ICCardSystem.Common
{
    /// <summary>
    /// 算法的实现方式
    /// </summary>
    public enum AlgorithmKind
    {
        /// <summary>
        /// 普通实现
        /// </summary>
        CryptoServiceProvider,
        /// <summary>
        /// 托管代码实现
        /// </summary>
        Managed,
        /// <summary>
        /// 新一代系统内核实现
        /// </summary>
        Cng
    }

    // 使用MD5计算散列
    public class MD5Crypto : IDisposable
    {
        #region 字段属性

        private MD5 _MD5Alg;
        /// <summary>
        /// MD5哈希算法类
        /// </summary>
        public MD5 MD5Alg { get { return _MD5Alg; } }

        #endregion

        #region 构造函数

        /// <summary>
        /// 构造函数，默认采用MD5CryptoServiceProvider提供的方法
        /// </summary>
        public MD5Crypto()
        {
            _MD5Alg = new MD5CryptoServiceProvider();
        }

        /// <summary>
        /// 根据实现方式构造MD5算法类(Managed方式未实现)
        /// </summary>
        /// <param name="isCng">算法的实现方式(Managed无效)</param>
        public MD5Crypto(AlgorithmKind kind)
        {
            switch (kind)
            {
                case AlgorithmKind.CryptoServiceProvider:
                    _MD5Alg = new MD5CryptoServiceProvider();
                    break;
                case AlgorithmKind.Cng:
                    _MD5Alg = new MD5Cng();
                    break;
                default:
                    _MD5Alg = new MD5CryptoServiceProvider();
                    break;
            }
        }

        #endregion

        #region 哈希方法

        /// <summary>
        /// 计算指定字节数组的哈希值
        /// </summary>
        /// <param name="input">输入</param>
        public byte[] ComputeHash(byte[] input)
        {
            return _MD5Alg.ComputeHash(input);
        }

        /// <summary>
        /// 计算指定字节数组区域的哈希值
        /// </summary>
        /// <param name="input">输入</param>
        /// <param name="start">起始位置</param>
        /// <param name="count">总字节数</param>
        public byte[] ComputeHash(byte[] input, int start, int count)
        {
            return _MD5Alg.ComputeHash(input, start, count);
        }

        /// <summary>
        /// 计算指定 System.IO.Stream 对象的哈希值
        /// </summary>
        /// <param name="inputStream">输入</param>
        public byte[] ComputeHash(Stream inputStream)
        {
            return _MD5Alg.ComputeHash(inputStream);
        }

        /// <summary>
        /// 计算指定字符串的哈希值
        /// </summary>
        /// <param name="input">输入</param>
        public byte[] ComputeHash(string input)
        {
            return _MD5Alg.ComputeHash(Encoding.Unicode.GetBytes(input));
        }

        #endregion

        #region 析构方法

        public void Clear()
        {
            _MD5Alg.Clear();
        }

        public void Dispose()
        {
            _MD5Alg.Dispose();
        }

        #endregion
    }
}