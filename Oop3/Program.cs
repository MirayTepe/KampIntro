using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyackrediManager = new IhtiyacKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>() { new SmsLoggerService(),new FileLoggerService()};

            BasvuruManager basvuruManager = new BasvuruManager();
            // basvuruManager.BasvuruYap(new EsnafKredisiManager(),new List<ILoggerService> {new DatabaseLoggerService(),new SmsLoggerService() });
            basvuruManager.BasvuruYap(new EsnafKredisiManager(),loggers);
            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyackrediManager,tasitKrediManager};
            // basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}