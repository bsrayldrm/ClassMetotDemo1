using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo1
{
    class MusteriManager
    {
        public void ekle(Musteri musteri)
        {

            Console.WriteLine("Müşteri banka listesine eklendi:" + musteri.Adi);
        }

        public void sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri banka listesinden çıkartıldı:" + musteri.Adi);
        }


        public void listele(Musteri musteri)
        {

            Console.WriteLine("Eklenen müşteriler listelendi!");
            Console.WriteLine("-" + musteri.Adi);

        }

    }
}