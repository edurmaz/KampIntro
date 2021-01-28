using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomerManager musteriManager = new CustomerManager();

            Customer musteri1 = new Customer();
            musteri1.Id = 123;
            musteri1.Adi = "Ahmet";
            musteri1.Soyadi = "Karaahmetoğlu";
            musteri1.Bakiye = 48600;


            Customer musteri2 = new Customer();
            musteri2.Id = 124;
            musteri2.Adi = "Sinan";
            musteri2.Soyadi = "Bikey";
            musteri2.Bakiye = 4500.12;


            Customer musteri3 = new Customer();
            musteri3.Id = 125;
            musteri3.Adi = "Cennet";
            musteri3.Soyadi = "Çukur";
            musteri3.Bakiye = 1652.6;

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("kişiler ekleniyor...");
            Console.WriteLine("---------------------------------------------");
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            Console.WriteLine("\n");



            Customer[] musteriler = new Customer[] { musteri1, musteri2, musteri3 };
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("kişiler listeleniyor...");
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine(" Id" + "   " + "Adı" + "   " + "Soyadı" + "   " + "Bakiye");
            Console.WriteLine("---------------------------------------------");

            foreach (Customer x in musteriler)
            {
                musteriManager.Listele(x);
            }

            Console.WriteLine("\n");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("kişiler siliniyor...");
            Console.WriteLine("---------------------------------------------");
            musteriManager.Delete(musteri1);
            musteriManager.Delete(musteri2);
            musteriManager.Delete(musteri3);

        }
    }
}
