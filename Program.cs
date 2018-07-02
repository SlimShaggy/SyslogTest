using System;
using NLog;
using System.Threading;

namespace SyslogTest
{
    class Program
    {
        private static int messageCount = 5000;

        static void Main(string[] args)
        {
            var nlog = LogManager.GetCurrentClassLogger();
            int i = 1;
            while (true)
            {
                if (i <= messageCount)
                {
                    Console.WriteLine($"Sending message #{i}");
                    nlog.Info("Test log message");
                    i++;
                }
                Thread.Sleep(10);
            }
        }
    }
}
