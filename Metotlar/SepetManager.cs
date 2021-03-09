using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Product product)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi:" + product.Adi);
        }

        public void Ekle2(string urunadi, string aciklama, double fiyat, int stokadeti)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi:" + urunadi);
        }

    }
}