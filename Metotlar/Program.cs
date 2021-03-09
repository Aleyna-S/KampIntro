using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyat = 15;
            product1.Aciklama = "Amasya Elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyat = 80;
            product2.Aciklama = "Diyarbakır Karpuzu";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyat);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("-----------------------");

            }

            Console.WriteLine("---------------Metotlar-------------");
            //Instance --> Örnek
            //Encapsulation
            SepetManager sepetManeger = new SepetManager();
            sepetManeger.Ekle(product1);
            sepetManeger.Ekle(product2);

            sepetManeger.Ekle2("Armut", "Yeşil Armut", 12, 9);
            sepetManeger.Ekle2("Elma", "Yeşil Elma", 21, 8);
            sepetManeger.Ekle2("Karpuz", "Diyarbakır Karpuzu", 80, 7);
        }
    }
}