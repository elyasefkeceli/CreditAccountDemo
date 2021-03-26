using System;
using System.Collections.Generic;
using System.Text;

namespace CreditAccountDemo
{
    class SmsLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms loglandı.");
        }
    }
}
