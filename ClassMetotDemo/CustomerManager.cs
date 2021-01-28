using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
       
            public void Listele(Customer musteri)
        {
            Console.WriteLine("" + musteri.Id + "  " + " " + musteri.Adi + " " + " " + musteri.Soyadi + " " + "  " + musteri.Bakiye);
        }
        public void Ekle(Customer musteri)
        {

            Console.WriteLine("" + musteri.Id + " " + " " + musteri.Adi + " " + " " + musteri.Soyadi + " " + " " + musteri.Bakiye + " " + "KİŞİ EKLENDİ!");
        }
        public void Delete(Customer musteri)
        {
            Console.WriteLine("Adı:  " + musteri.Adi + " " + "Soyadı:  " + musteri.Soyadi + " " + "Bakiyesi:  " + musteri.Bakiye + " " + "olan kişi silindi!");
        }
    }
}
