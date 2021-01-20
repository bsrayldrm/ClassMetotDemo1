using System;

namespace ClassMetotDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Hazin Yıldırım";
            musteri1.Yaşı = 55;
            musteri1.KrediNotu = 1600;
            musteri1.KartÇeşidi = "Bankamatik Kartı";

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Buket Erol";
            musteri2.Yaşı = 30;
            musteri2.KrediNotu = 1900;
            musteri2.KartÇeşidi = "Maximiles";

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Dilan Kırmızı";
            musteri3.Yaşı = 25;
            musteri3.KrediNotu = 1250;
            musteri3.KartÇeşidi = "Ön ödemeli kart";


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Yaşı);
                Console.WriteLine(musteri.KrediNotu);
                Console.WriteLine(musteri.KartÇeşidi);
                Console.WriteLine("------------------");



            }




            MusteriManager musteriManager = new MusteriManager();
            musteriManager.ekle(musteri1);
            musteriManager.ekle(musteri2);
            musteriManager.ekle(musteri3);

            musteriManager.listele(musteri1);
            musteriManager.listele(musteri2);
            musteriManager.listele(musteri3);


            musteriManager.sil(musteri3);


        }
    }
}
