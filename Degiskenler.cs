using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string sehir,ilce;   // String = Yazılarda kullanılır
            sehir = "Bursa";
            ilce = "Yıldırım";    // "=" atama için kullanılır

            Console.WriteLine(sehir+"-"+ilce);

            int a, b, c;   // İnt = Sayılarda kullanılır 
            a = 6;
            b = 8;
            c = 95;
            Console.WriteLine(a + b + c);
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
             
            */

            // Soru: Kısa ve uzun kenarı kod kısmından girilen dikdörtgenin alan ve çevresini hesaplayan kodu yazın.



            /* int kisakenar, uzunkenar, alan,cevre;

             kisakenar = 5;
             uzunkenar = 12;

             alan = kisakenar * uzunkenar;
             cevre = (kisakenar + uzunkenar) * 2;

             Console.WriteLine("Cevre: "+ cevre);
             Console.Write("Alan: " + alan);     
            */
            // Aritmetik işlemler
            /*
            int s1, s2, toplam, carpim, bolum, fark;

            Console.WriteLine("***** Aritmetik İşlemler *****");
            Console.WriteLine();

            s1 = 16;
            s2 = 85;

            toplam = s1 + s2;
            carpim= s1 * s2;
            bolum= s1 / s2;
            fark= s1 - s2;

            Console.WriteLine("Toplam; " + toplam);
            Console.WriteLine("Çarpım: " + carpim);
            Console.WriteLine("Bölüm; " + bolum);
            Console.WriteLine("Fark; " + fark);
            Console.WriteLine();
            Console.WriteLine("***** Aritmetik İşlemler *****");

            */
            /*
            // Sınav not uygulaması

            string ad, soyad, bolum, ders;
            int s1, s2,s3, ort;

            // string değişkenleri atamaları

            ad = "Eren";
            soyad = "Güngörmez";
            bolum = "Bilgisayar Programcılığı";
            ders = "c# eğitimi";

            // Int değişkenleri atamaları   
            s1 = 65;
            s2 = 49;
            s3 = 60;

            ort = (s1 + s2 + s3) / 3;

*/
            //  Yazdırma Komutları 

            /* Console.WriteLine("***** Öğrenci Bilgi Sistemi*****");
             Console.WriteLine();
             Console.WriteLine("Öğrenci adı soyadı: " + ad + " " + soyad);
             Console.WriteLine("Bölüm: " + bolum);
             Console.WriteLine("Ders: " + ders);
             Console.WriteLine();
             Console.WriteLine("Sınav 1: " + s1);
             Console.WriteLine("Sınav 2: " + s2);
             Console.WriteLine("Sınav 3: " + s3);
             Console.WriteLine("Ortalamanız: " + ort); */


            //double sayi;  // Double = Ondalıklı sayılarla işlem yapmaya yarar

            //sayi = 24.9;
            //Console.WriteLine(sayi);  // 24.9


            //double s1, s2, ort;

            //s1 = 78;
            //s2 = 40;

            //ort = (s1 + s2) / 2;

            //Console.WriteLine(ort);


            // Klavyeden Veri Girişi Yapma


            //string il, ilce;

            //Console.Write("İl bilgisini giriniz: ");
            //il = Console.ReadLine();

            //Console.Write("İlçe bilgisini giriniz: ");
            //ilce = Console.ReadLine();

            //Console.WriteLine("İl ve ilçe bilgileri: "+  il +" - "+ ilce);

            // Int Dönüşümler 
            //int a;

            //Console.WriteLine("A için bir sayı değeri giriniz");
            //a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("a sayısı: " + a);


            //int s1, s2, ort;

            //Console.WriteLine("Bir sayı giriniz; ");
            //s1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Bir sayı giriniz; ");
            //s2 = Convert.ToInt32(Console.ReadLine());

            //ort = (s1 + s2) / 2;

            //Console.WriteLine("İki sayinin ortalaması: " + ort);


            // Soru: Klavyeden kısa ve uzun kenarı girilen dikdörtgenin alan ve çevresini hesaplayan kodu yazınız.

            /*
                        int kkenar, ukenar, alan, cevre;

                        Console.Write("Kısa Kenar bilgisi giriniz: ");
                        kkenar = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Uzun Kenar bilgisi giriniz: ");
                        ukenar = Convert.ToInt32(Console.ReadLine());

                        cevre = (kkenar + ukenar) * 2;
                        alan = kkenar * ukenar;

                        Console.WriteLine("Alan: " + alan);
                        Console.Write("Cevre " + cevre);


            */



            // Soru: Klavyeden girilen 2 sayıya aritmetik 4 işlem uygulayan kodu yazın.

            /*
            double s1, s2, toplam, fark, carpim, bolum;

            Console.Write("Bir sayı giriniz: ");
            s1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz: ");
            s2 = Convert.ToDouble(Console.ReadLine());


            toplam = s1 + s2;
            fark = s1 - s2;
            carpim= s1 * s2;
            bolum = s1 / s2;

            Console.WriteLine(" Sayılar toplamı: " + toplam);
            Console.WriteLine(" Sayılar farkı: " +  fark);
            Console.WriteLine(" Sayılar çarpımı: " + carpim);
            Console.WriteLine(" Sayılar bölümü: " + bolum);

            */


            // Char Değişkeni


            //char degisken;

            //degisken = 'a';  // Tek tırnak ve sadece bir sembol kullanılabilir

            //Console.WriteLine(degisken);



            // Float türünden değişkenler


            //float sayi;

            //sayi = 35.58f;  // sayıdan sonra "f" kullanılmalı.
            //Console.WriteLine(sayi);


            //float s1, s2, toplam;

            //Console.Write("Sayi1= ");
            //s1 = float.Parse(Console.ReadLine()); // normalde "convert" metodu kullanılırken "parse" metodu kullanılıyor
            //Console.Write("Sayi2= ");
            //s2 = float.Parse(Console.ReadLine());

            //toplam = s1 + s2;

            //Console.Write("Girdiğiniz sayıların toplamı: "+ toplam);




            // Degiskenlerde max-min value

          // Console.WriteLine(int.MaxValue); // int in olabilecek en yüksek değerini gösteriyor
          // Console.WriteLine(int.MinValue); // int in olabilecek en düşük değerini gösteriyor



















            Console.ReadLine();
        }
    }
}
