using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi : "+ musteri.Ad + " " + musteri.Soyad);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi : " + musteri.Ad + " " + musteri.Soyad);
        }

        public void Listele(Musteri musteri)
        {
            Musteri m1 = new Musteri()
            {
                Ad = "Ahmet",
                Soyad = "Mümtaz",
                Yaş = 33,
                Id = 12345678912
            };

            Musteri[] musteriListesi1 = new Musteri[] { m1 };
            foreach (var m in musteriListesi1)
            {
                Console.WriteLine(m1.Ad + " " + m1.Soyad);
                Console.WriteLine("Yaşı : " + m1.Yaş);
                Console.WriteLine("İD'si : " + m1.Id);
            }
        }

        public void Listele2(Musteri musteri)
        {
            Musteri m2 = new Musteri()
            {
                Ad = "Mehmet",
                Soyad = "Taş",
                Yaş = 28,
                Id = 25789635896
            };

            Musteri[] musteriListesi2 = new Musteri[] { m2 };
            foreach (var m in musteriListesi2)
            {
                Console.WriteLine(m2.Ad + " " + m2.Soyad);
                Console.WriteLine("Yaşı : " + m2.Yaş);
                Console.WriteLine("İD'si : " + m2.Id);
            }
        }

        public void Listele3(Musteri musteri)
        {
            Musteri m3 = new Musteri()
            {
                Ad = "Ali",
                Soyad = "Vural",
                Yaş = 42,
                Id = 475203698525
            };

            Musteri[] musteriListesi3 = new Musteri[] { m3 };
            foreach (var m in musteriListesi3)
            {
                Console.WriteLine(m3.Ad + " " + m3.Soyad);
                Console.WriteLine("Yaşı : " + m3.Yaş);
                Console.WriteLine("İD'si : " + m3.Id);
            }
        }
    }
}
