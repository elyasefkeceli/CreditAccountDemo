using System;
using System.Collections.Generic;
using System.Text;

namespace CreditAccountDemo
{
    class IhtiyacCreditManager : ICreditManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }
        public void Hesapla()
        {
            Console.WriteLine("Ihtiyac kredisi hesaplandı");
        }
    }
}
