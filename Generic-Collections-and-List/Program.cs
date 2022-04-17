using System;
using System.Collections.Generic;

namespace Generic_Collections_and_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> renkler = new List<string>();
            renkler.Add("Kırmızı");
            renkler.Add("Mavi");
            renkler.Add("Yeşil");
            renkler.Add("Sarı");

            foreach (var item in renkler)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("***** ForEach new *****");

            renkler.ForEach(renk => Console.WriteLine(renk)); // ForEach döngüsü kısayolu

            List<int> sayilar = new List<int>();
            sayilar.Add(5);
            sayilar.Add(10);
            sayilar.Add(20);

            sayilar.ForEach(sayi => Console.WriteLine(sayi));

            sayilar.Remove(5); // Belirtilen değeri listeden çıkart
            renkler.Remove("Kırmızı");

            sayilar.RemoveAt(0); // belirtilen indexte bulunan değeri çıkart
            renkler.RemoveAt(1);

            renkler.ForEach(renk => Console.WriteLine(renk));
            sayilar.ForEach(sayi => Console.WriteLine(sayi));

            // Liste içinde arama
            if (sayilar.Contains(20))
                Console.WriteLine("Sayilar listesi içerisinde 20 değeri bulundu ");
            
            // Eleman ile index sorugulama
            Console.WriteLine(renkler.BinarySearch("Sarı"));

            // Diziyi Listeye Çevirme
            string[] Hayvanlar = {"Kedi","Köpek","Kuş"};
            List<string> hayvanlarListesi = new List<string>(Hayvanlar);

            //Lisetyi Temizleme
            hayvanlarListesi.Clear();

            //List içerisinde nesne tutmak
            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();

            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Isim = "Furkan";
            kullanici1.Soyisim = "Avunca";
            kullanici1.Yas = 22;

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isim = "Ahmet";
            kullanici2.Soyisim = "Avunca";
            kullanici2.Yas = 22;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();
            
            yeniListe.Add(new Kullanicilar(){
                Isim="Mehmet",
                Soyisim="Can",
                Yas = 18
            });

            kullaniciListesi.ForEach(kullanicilar => Console.WriteLine("Kullanici adi: " + kullanicilar.Isim + " \nKullanici Soyadi: " + kullanicilar.Soyisim + "\nKullanici Yasi: " + kullanicilar.Yas));
            yeniListe.Clear();
        }
        public class Kullanicilar
        {
            private string isim;
            private string soyisim;
            private int yas;

            public string Isim {get => isim; set => isim = value;}
            public string Soyisim {get => soyisim; set => soyisim = value;}

            public int Yas{get => yas; set => yas = value;}
        }
    }
}
