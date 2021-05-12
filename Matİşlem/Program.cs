using System;

namespace MatematikIslem
{
    class Program //öznur paylan
    {
        static void Main(string[] args)
        {            
         while (0 == 0)  
         {
            int secim;
            Console.WriteLine("**ARİTMETİK İŞLEMLER UYGULAMASI**");
            Console.WriteLine("**YAPACAĞINIZ İŞLEMİ MENÜDEN SEÇİNİZ**");
            Console.WriteLine("************MENÜ************");
            Console.WriteLine("1-İki sayıya aritmetik 4 işlem uygulama");
            Console.WriteLine("2-Üs alma");
            Console.WriteLine("3-Kök bulma");
            Console.WriteLine("4-Faktöriyel bulma");
            Console.WriteLine("5-Girilen sayı kadar ortalama bulma");
            Console.WriteLine("6-Karenin alan ve çevre hesabı");
            Console.WriteLine("7-Dikdörtgenin alan ve çevre hesabı");
            Console.WriteLine("8-Eşkenar üçgenin alan ve çevre hesabı");
            Console.WriteLine("9-Çemberin alan ve çevre hesabı");
            Console.WriteLine("**************");
            Console.Write("Yapmak istediğiniz işlem: ");
            secim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (secim == 1)
            {
                Console.WriteLine("***1-İki sayıya aritmetik 4 işlem uygulama***");
                int a, b, toplam, carpim, bolum, fark;
                Console.Write("1.sayıyı girin: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("2.sayıyı girin: ");
                b = Convert.ToInt32(Console.ReadLine());
                toplam = a + b;
                carpim = a * b;
                bolum = a / b;
                fark = a - b;
                Console.WriteLine("Toplam: " + toplam);
                Console.WriteLine("Çarpım: " + carpim);
                Console.WriteLine("Bölüm: " + bolum);
                Console.WriteLine("Fark: " + fark);
            }

            if (secim == 2)
            {
                Console.WriteLine("***2-Üs alma***");
                double sayi, us, sonuc;
                Console.Write("Üssü alınacak sayıyı giriniz: ");
                sayi = Convert.ToDouble(Console.ReadLine());
                Console.Write("Üssü girin: ");
                us = Convert.ToDouble(Console.ReadLine());
                sonuc = Math.Pow(sayi, us);
                Console.WriteLine("Sonuç: " + sonuc);
            }

            if (secim == 3)
            {
                Console.WriteLine("***3-Kök bulma***");
                double sayi, kok;
                Console.Write("Kökü alınacak sayı: ");
                sayi = Convert.ToDouble(Console.ReadLine());
                kok = Math.Sqrt(sayi);
                Console.WriteLine("Kök değeri: " + kok);
            }

            if (secim == 4)
            {
                Console.WriteLine("***4-Faktöriyel bulma***");
                int sayi;
                int faktöriyel = 1;
                Console.Write("Faktöriyeli alınacak sayı: ");
                sayi = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= sayi; i++)
                {
                    faktöriyel = faktöriyel * i;
                }
                Console.WriteLine("Sayının faktöriyeli: " + faktöriyel);
            }

            if (secim == 5)
            {
                Console.WriteLine("***5-Girilen sayı kadar ortalama bulma***");
                double toplam = 0, ortalama = 0;
                int adet;
                Console.Write("Kaç adet sayının ortalaması hesaplanacak: ");
                adet = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= adet; i++)
                {
                    Console.Write(i + ".sayıyı giriniz: ");
                    double sayi = Convert.ToDouble(Console.ReadLine());
                    toplam += sayi;
                }
                ortalama = toplam / adet;
                Console.WriteLine("Saayıların ortalaması: " + ortalama);
            }

            if (secim == 6)
            {
                Console.WriteLine("***6-Karenin alan ve cevre hesabı***");
                int kenar, alan, cevre;
                Console.Write("Kenar uzunluğunu giriniz: ");
                kenar = Convert.ToInt32(Console.ReadLine());
                alan = kenar * kenar;
                cevre = kenar * 4;
                Console.WriteLine("Alan: " + alan);
                Console.WriteLine("Çevre: " + cevre);
            }

            if (secim == 7)
            {
                Console.WriteLine("***7-Dikdörtgenin alan ve çevre hesabı***");
                int kisakenar, uzunkenar, alan, cevre;
                Console.Write("Kısa kenar uzunluğunu giriniz: ");
                kisakenar = Convert.ToInt32(Console.ReadLine());
                Console.Write("Uzun kenar uzunluğunu giriniz: ");
                uzunkenar = Convert.ToInt32(Console.ReadLine());
                alan = kisakenar * uzunkenar;
                cevre = (2 * kisakenar) + (2 * uzunkenar);
                Console.WriteLine("Alan: " + alan);
                Console.WriteLine("Çevre: " + cevre);
            }

            if (secim == 8)
            {
                Console.WriteLine("***8-Eşkenar üçgenin alan ve çevre hesabı***");
                int kenar, cevre;
                double alan, kok;
                kok = Math.Sqrt(3);
                Console.Write("Kenar uzunluğunu giriniz: ");
                kenar = Convert.ToInt32(Console.ReadLine());
                alan = (kenar * kenar) * kok / 4;
                cevre = 3 * kenar;
                Console.WriteLine("Alan: " + alan);
                Console.WriteLine("Çevre: " + cevre);
            }

            if (secim == 9)
            {
                Console.WriteLine("***9-Çemberin alan ve çevre hesabı***");
                double r, alan, cevre;
                Console.Write("Yarıçap uzunluğu: ");
                r = Convert.ToDouble(Console.ReadLine());
                alan = 3 * r * r;
                cevre = 2 * 3 * r;
                Console.WriteLine("Alan: " + alan);
                Console.WriteLine("Çevre: " + cevre);
            }

            if (secim < 1 || secim > 9)
            {
                Console.WriteLine("Menüde olmayan bir seçim yaptınız!");
            } 
            
            Console.Write("Çikmak ister misiniz....(E/H)");
                 if (Console.ReadLine() == "E") break;
         }  
        }
    }
}