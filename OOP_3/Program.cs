using System;
using System.Collections.Generic;

namespace OOP_3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasıtKrediManeger = new TasıtKrediManeger();
            IKrediManager konutKredianager = new KonutKredianager();

            ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager,fileLoggerService);


            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasıtKrediManeger };

            //basvuruManager.KrdiOnBilgilendirmesiYap(krediler);
        }
    }
}
