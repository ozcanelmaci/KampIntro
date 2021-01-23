using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>();
            loggers.Add(databaseLoggerService);
            loggers.Add(fileLoggerService);
            loggers.Add(smsLoggerService);

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKrediManager(),loggers);

            List<IKrediManager> krediler = new List<IKrediManager>();

            krediler.Add(ihtiyacKrediManager);
            krediler.Add(tasitKrediManager);

           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
