using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{
    class DataBaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veri tabanına loglandı");
        }
    }
}
