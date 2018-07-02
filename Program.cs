using NLog;
using System.Threading;

namespace SyslogTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var nlog = LogManager.GetCurrentClassLogger();
            while (true)
            {
                nlog.Info("Test log message");
                Thread.Sleep(10);
            }
        }
    }
}
