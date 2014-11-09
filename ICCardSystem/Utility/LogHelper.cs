using System;
using System.IO;
using ICCardSystem.Common;

namespace ICCardSystem.Utility
{
    public class LogHelper
    {
        private static readonly object _WriteFile = new object();
        private static readonly string _Directory = ICCardSystem.Common.Computer.ServerPath;
        private static StreamWriter streamWriter;    //写文件

        /// <summary>
        /// 在服务器上写入错误日志
        /// </summary>
        /// <param name="exception">错误信息</param>
        public static void WriteLog(Exception exception)
        {
            if (exception.InnerException != null)
                WriteLog(exception.InnerException.StackTrace, exception.InnerException.Message);
            else
                WriteLog(exception.StackTrace, exception.Message);
        }
        /// <summary>
        /// 写日志信息
        /// </summary>
        /// <param name="trace">错误位置</param>
        /// <param name="strLog">信息内容</param>
        public static void WriteLog(string trace, string strLog)
        {
            lock (_WriteFile)
            {
                try
                {
                    DateTime dt = DateTime.Now;
                    string directPath = string.Format("{0}Error_Log", _Directory);
                    if (!Directory.Exists(directPath))
                        Directory.CreateDirectory(directPath);
                    directPath += string.Format(@"\{0}.log", dt.ToString("yyyy-MM-dd"));
                    InitLog(directPath);
                    streamWriter.WriteLine("***********************************************************************");
                    streamWriter.WriteLine("记录时间：" + dt.ToString("yyyy-MM-dd HH:mm:ss"));
                    streamWriter.WriteLine("错误信息：" + strLog);
                    streamWriter.WriteLine("跟踪记录：");
                    streamWriter.WriteLine(trace);
                }
                finally
                {
                    if (streamWriter != null)
                    {
                        streamWriter.Flush();
                        streamWriter.Dispose();
                        streamWriter = null;
                    }
                }
            }
        }

        private static void InitLog(string filPath)
        {
            streamWriter = !File.Exists(filPath) ? File.CreateText(filPath) : File.AppendText(filPath);
        }
    }
}