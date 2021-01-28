using System;

namespace KampIntro
{
	class Program
	{
		static void Main(string[] args)
		{
			//type safety - tip güvenliği
			//kategoriEtiketi değer tutucudur.
			string kategoriEtiketi = "Kategori";
			int ogrenciSayisi = 32000;
			double faizOranı = 1.45;
			bool sistemeGirisYapmisMi = true;
			double dolarDun = 7.45;
			double dolarBugun = 7.45;

			if (dolarDun>dolarBugun)
			{
				Console.WriteLine("Azalış Butonu");
			}
			else if (dolarDun<dolarBugun)
            {
				Console.WriteLine("Artış Butonu");
            }
            else
            {
				Console.WriteLine("Değişmedi butonu");
            }


            if (sistemeGirisYapmisMi == true)
            {
				Console.WriteLine("Kullanıcı ayarları butonu");
				
			}
            else
            {
				Console.WriteLine("Giriş Yap butonu");
            }
			Console.WriteLine(kategoriEtiketi);
		
		



		}
	}
}
