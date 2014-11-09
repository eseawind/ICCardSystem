using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;

namespace ICCardSystem.Common
{
    public class Computer
    {
        #region 获取本机IP地址

        /// <summary>
        /// 获取本机所有网卡的IPv4地址
        /// </summary>
        public IList<string> GetLocalIPv4()
        {
            IList<string> IpList = new List<string>();
            IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress ip in localIPs)
            {
                //根据AddressFamily判断是否为ipv4,如果是InterNetWork则为ipv4
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    IpList.Add(ip.ToString());
            }
            return IpList;
        }

        #endregion

        #region 获取当前路径

        /// <summary>
        /// 获取服务器根目录物理绝对路径
        /// </summary>        
        public static string ServerPath
        {
            get
            {
                // HttpRuntime.AppDomainAppPath;
                // HttpContext.Current.Request.PhysicalPath;             // 获得当前页面的完整物理路径
                // HttpContext.Current.Request.PhysicalApplicationPath;  // 获得当前程序运行的物理路径
                return System.AppDomain.CurrentDomain.BaseDirectory;     // 在dll中调用获取当前的web站点的工作目录
            }
        }

        #endregion

        #region 进程管理

        /// <summary>
        /// 手动关闭进程
        /// </summary>
        /// <param name="list">进程列表</param>
        public static bool KillProcess(IEnumerable<Process> list)
        {
            try
            {
                foreach (Process theProc in list)
                    if (theProc.CloseMainWindow() == false)
                        theProc.Kill();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 比较两个进程是否相同
        /// </summary>
        public class ProcessComparer : IEqualityComparer<Process>
        {
            public bool Equals(Process x, Process y)
            {
                return x.Id == y.Id;
            }

            public int GetHashCode(Process obj)
            {
                return obj.Id;
            }
        }

        #endregion
    }
}