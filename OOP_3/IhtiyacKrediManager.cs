﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{
    class IhtiyacKrediManager : IKrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplındı");
        }
    }
}
