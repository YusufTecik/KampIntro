﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    public class Urun
    {
        //PROPERTY(PROP) = ÖZELLİK
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyat { get; set; }
        public string Aciklama { get; set; }
        public int stokAdedi { get; set; }
    }
}
