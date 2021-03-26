using System;
using System.Collections.Generic;
using System.Text;

namespace CreditAccountDemo
{
    class KonutCreditManager : ICreditManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Konut kredisi hesaplandı");
        }
    }
}
