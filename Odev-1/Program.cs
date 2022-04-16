using System;

namespace Odev_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Soru 1 *****");
            Console.Write("Kaç adet sayi istediğinizi girin: ");
            int sayi = int.Parse(Console.ReadLine());
            if(sayi <= 0)
                Console.WriteLine("Hatali sayi girisi yapildi! ");
            else
            {
                int[] sayiDizi = new int[sayi];
                for (int i = 0; i < sayiDizi.Length; i++)
                {
                    Console.Write("{0}. sayiyi giriniz: ", i + 1); 
                    int girilenSayi = int.Parse(Console.ReadLine());
                    sayiDizi[i] = girilenSayi;
                }
                for (int i = 0; i < sayiDizi.Length; i++)
                {
                    if(sayiDizi[i] % 2 == 0)
                        Console.WriteLine(sayiDizi[i]);
                }
            }

            Console.WriteLine("***** Soru 2 *****");
            Console.Write("Kaç adet sayi istediginizi girin: ");
            sayi = int.Parse(Console.ReadLine());
            Console.Write("Baz alinacak sayiyi girini: ");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Diziniz Oluşturuluyor... ");
            if (sayi <= 0 && sayi2 <=0)
                Console.WriteLine("Yanlis sayi girdiniz! ");
            else
            {
                int girilenSayi2;
                int[] sayiDizisi2 = new int[sayi];
                for (int i = 0; i < sayiDizisi2.Length; i++)
                {
                    Console.Write("{0}. sayiyi giriniz: ", i + 1);
                    girilenSayi2 = int.Parse(Console.ReadLine());
                    sayiDizisi2[i] = girilenSayi2;
                }

                for (int i = 0; i < sayiDizisi2.Length; i++)
                {
                    if (sayiDizisi2[i] % sayi2 == 0 || sayiDizisi2[i] == sayi2)
                    {
                        Console.WriteLine(sayiDizisi2[i]);
                    }
                }
            }

            Console.WriteLine("***** Soru 3 *****");
            Console.Write("Kaç adet kelime girilecek: ");
            int kelimeSayisi = int.Parse(Console.ReadLine());
            if(kelimeSayisi <= 0)
                Console.WriteLine("Yanlis sayi girdiniz! ");
            else
            {
                string[] kelimelerDizisi = new string[kelimeSayisi];
                for (int i = 0; i < kelimelerDizisi.Length; i++)
                {
                    Console.Write("{0}. kelimeyi giriniz: ",i+1);
                    kelimelerDizisi[i] = Console.ReadLine();
                }

                Array.Reverse(kelimelerDizisi);

                for (int i = 0; i < kelimelerDizisi.Length; i++)
                {
                    Console.WriteLine(kelimelerDizisi[i]);
                }
            }

            Console.WriteLine("***** Soru 4 *****");
            Console.WriteLine("Kelime ve harf sayisinin hesaplanilmasini istediginiz cumleyi girin: ");
            string girilenCumle = Console.ReadLine();
            string[] cumle = girilenCumle.Split(" ");
            Console.WriteLine("Kelime sayisi: " + cumle.Length);
            Console.WriteLine("Harf Sayisi: " + (girilenCumle.Length - (cumle.Length-1)));
        }
    }
}
