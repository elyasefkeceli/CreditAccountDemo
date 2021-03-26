using System;
using System.Collections.Generic;

namespace CreditAccountDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            

            List<ILoggerService> loggers = new List<ILoggerService> { new FileLoggerService(), new DatabaseLoggerService() ,new SmsLoggerService()};
           
            
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new TasitCreditManager(),loggers);
            List<ICreditManager> credits = new List<ICreditManager> { new TasitCreditManager(), new IhtiyacCreditManager(),new EsnafCreditManager(),new KonutCreditManager() };
            //basvuruManager.CreditOnBasvuruYap(credits);
        }
    }
}
