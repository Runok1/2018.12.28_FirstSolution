using log4net;
using System;
using System.Xml;

namespace HW
{
    public class Program
    {
        private static readonly ILog log = LogManager
            .GetLogger(typeof (Program));

        static void ShowSeason(int monthNumber)
        {
            if (monthNumber >= 3 && monthNumber <= 5)
            {
                Console.WriteLine("Spring");
            }
        }

        public static void Main(string[] args)
        {
            //int monthNumber = 3;
            //ShowSeason(monthNumber);
            //Animal.MakeSound("Gav");

            log.Debug("debug");
            log.Info("info");
            log.Warn("warn");
            log.Error("error");
            log.Fatal("fatal");

            Console.ReadKey();

            //XmlDocument xml = new XmlDocument();
            //xml.LoadXml("path to file");
        }
    }
}
