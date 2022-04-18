using System;
using System.Collections.Generic;
using System.Collections;

namespace Odev_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Soru 1
            Console.WriteLine("***** Soru 1 *****");
            ArrayList asalSayilar = new ArrayList();
            ArrayList asalOlmayanSayilar = new ArrayList();
            int sayiAdeti = 20;
            int girilenSayi = 0;
            for (int i = 0; i < sayiAdeti; i++)
            {
                try
                {
                    Console.Write("{0}. Sayıyı Girin: ",i + 1);
                    girilenSayi = int.Parse(Console.ReadLine());
                    if(girilenSayi > 0)
                    {
                        if (girilenSayi == 1)
                        {
                            asalOlmayanSayilar.Add(girilenSayi);
                        }
                        else
                        {
                            int kontrol = 0;
                            int x = 2;
                            while (x < girilenSayi)
                            {
                                if (girilenSayi % x == 0)
                                    kontrol++;
                                x++;
                            }
                            if (kontrol != 0)
                                asalOlmayanSayilar.Add(girilenSayi);
                            else
                                asalSayilar.Add(girilenSayi);
                            }
                    }
                    else
                    {
                        Console.WriteLine("Negatif bir değer girdiniz! ");
                        i--;
                }   
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Lütfen sadece sayı girin! ");
                    i--;
                }
                
            }
            asalSayilar.Reverse();
            asalOlmayanSayilar.Reverse();
            Console.WriteLine("Asal Sayılar ");
            foreach (var item in asalSayilar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Asal Olmayan Sayılar ");
            foreach (var item in asalOlmayanSayilar)
            {
                 Console.WriteLine(item);
            }
            Console.WriteLine("Asal olan sayılın adeti: " + asalSayilar.Count);
            Console.WriteLine("Asal olmayan sayıların adeti: "+asalOlmayanSayilar.Count);

            double asalSayilarinToplami = 0;
            foreach (int item in asalSayilar)
            {
                asalSayilarinToplami += item;
            }
            asalSayilarinToplami /= asalSayilar.Count;
            Console.WriteLine("Asal sayıların ortalaması: " + asalSayilarinToplami);
            double asalOlmayanSayilarinToplami = 0;
            foreach (int item in asalOlmayanSayilar)
            {
                asalOlmayanSayilarinToplami += item;
            }
            asalOlmayanSayilarinToplami /= asalOlmayanSayilar.Count;
            Console.WriteLine("Asal olmayan sayıların ortalaması: "+ asalOlmayanSayilarinToplami);

            // Soru 2
            Console.WriteLine("***** Soru 2 *****");
            ArrayList sayilar = new ArrayList();
            int[] sayiDizi = new int[20];
            ArrayList enBuyuk = new ArrayList(3);
            ArrayList enKucuk = new ArrayList(3);
            girilenSayi = 0;
            for (int i = 0; i < sayiAdeti; i++)
            {
                try
                {
                    Console.Write("{0}. Sayıyı Girin: ",i + 1);
                    girilenSayi = int.Parse(Console.ReadLine());
                    sayilar.Add(girilenSayi);
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Lütfen sadece sayı girin! ");
                    i--;
                }
            }
            sayilar.Sort();
            sayilar.CopyTo(sayiDizi,0);
            
            for (int i = 0; i < 3; i++)
            {
                enBuyuk.Add(sayiDizi[i]);
            }
            Array.Reverse(sayiDizi);
            for (int i = 0; i < 3; i++)
            {
                enKucuk.Add(sayiDizi[i]);
            }
            Console.WriteLine("En Küçük Sayılar: ");
            foreach (var item in enBuyuk)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("En Büyük Sayılar ");
            foreach (var item in enKucuk)
            {
                Console.WriteLine(item);
            }

            // Soru 3
            Console.WriteLine("***** Soru 3 *****");
            Console.WriteLine("Cümlenizi girin: ");
            string cümle = Console.ReadLine();
            char[] sesliHarfler={'a','e','ı','i','o','ö','u','ü'};

            List<Char> harf = new List<char>();

            foreach (var item in cümle)
            {
                foreach (var deger in sesliHarfler)
                {
                    if (item == deger)
                    {
                        if (harf.Contains(deger))
                            break;
                        else
                            harf.Add(item);
                    }
                }
            }

            Console.WriteLine("Cümlede Bulunan Sesli Harfler: ");
            foreach (var item in harf)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}
