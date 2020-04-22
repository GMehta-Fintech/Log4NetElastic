using System;
using log4net;
using log4net.Repository.Hierarchy;
using log4net.Core;
using log4net.Appender;
using log4net.Layout;

namespace TestConsol
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {

            log.Info("Hello Info world!");
            log.Error("Hello Error world!");
            log.Warn("Hello Warn world!");

            log.Info("Hello Info world!");
            log.Error("Hello Error world!");
            log.Warn("Hello Warn world!");

            log.Info("Hello Info world!");
            log.Error("Hello Error world!");
            log.Warn("Hello Warn world!");

            Console.WriteLine("Hit enter");
            Console.ReadLine();

        }
    }
}
