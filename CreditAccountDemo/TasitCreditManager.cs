using System;
using System.Collections.Generic;
using System.Text;

namespace CreditAccountDemo
{
    class TasitCreditManager : ICreditManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Tasit kredisi hesaplandı.");
        }
    }
}
