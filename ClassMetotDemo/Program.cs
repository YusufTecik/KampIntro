using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri()
            {
                Ad = "Ahmet",
                Soyad = "Mümtaz",
                Yaş = 33,
                Id = 12345678912
            };

            Musteri m2 = new Musteri()
            {
                Ad = "Mehmet",
                Soyad = "Taş",
                Yaş = 28,
                Id = 25789635896
            };
            Musteri m3 = new Musteri()
            {
                Ad = "Ali",
                Soyad = "Vural",
                Yaş = 42,
                Id = 475203698525
            };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Listele(m1);
            Console.WriteLine(" ");
            musteriManager.Listele2(m2);
            Console.WriteLine(" ");
            musteriManager.Listele3(m3);
            Console.WriteLine(" ");

            musteriManager.Ekle(m1);
            Console.WriteLine(" ");
            musteriManager.Ekle(m2);
            Console.WriteLine(" ");
            musteriManager.Ekle(m3);
            Console.WriteLine(" ");
            Console.WriteLine(" -------------------------- ");
            Console.WriteLine(" ");

            musteriManager.Sil(m1);
            Console.WriteLine(" ");
            musteriManager.Sil(m2);
            Console.WriteLine(" ");
            musteriManager.Sil(m3);
        }
    }
}
