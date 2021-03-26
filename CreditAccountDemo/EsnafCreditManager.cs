using System;
using System.Collections.Generic;
using System.Text;

namespace CreditAccountDemo
{
    class EsnafCreditManager : ICreditManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Esnaf kredisi hesaplandı.");
        }
    }
}
