﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class Product
    {
        //Property --> Özellik
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyat { get; set; }
        public string Aciklama { get; set; }
        public int StokAdeti { get; set; }
    }
}