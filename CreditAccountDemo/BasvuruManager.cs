using System;
using System.Collections.Generic;
using System.Text;

namespace CreditAccountDemo
{
    class BasvuruManager
    {
        public void BasvuruYap(ICreditManager creditManager,List<ILoggerService> loggerService) 
        {
            creditManager.Hesapla();
            foreach (var loggerService1 in loggerService)
            {
                loggerService1.Log();
            }
        }
        public void CreditOnBasvuruYap(List<ICreditManager>credits)
        {
            foreach (var credit in credits)
            {
                credit.Hesapla();
            }
        }
       
    }
}
