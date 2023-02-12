using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // DİZİLER



            //string[] sehirler = { "Bursa", "İstanbul", "Erzurum" }; // türü belirttikten sonra köşeli parantez
            //                                                        // Verileri belirtirken {} kullanılır
            //Console.WriteLine(sehirler[0]); // İndeksler 0 dan başlar
            //Console.WriteLine(sehirler[1]);
            //Console.WriteLine(sehirler[2]);

            // int değişkenlerle dizi kullanımı

            //int[] sayilar = { 1, 2, 3, 4, 5 };
            //Console.WriteLine(sayilar[3]); // sayılar dizisinin 3. indeksi


            // Eğer dizideki tüm verileri yazdırmak istiyorsak

            //int[] sayilar = { 1, 2, 3, 4, 5 };

            //for (int i = 0; i<6; i++)
            //{
            //    Console.WriteLine(sayilar[i]); // Sayıların i'ninci elemanından başlatarak yazdır 
            //} 

            // Dizilerle beraber karar yapılarının kullanımı

            //int[] sayilar = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };

            //for (int i = 0; i<sayilar.Length ; i++) // Lenght dizideki toplam veri satısını bulur
            //{
            //    if (sayilar[i]%20==0) // Eğer sayıları dzisinin i'ninci elemanı 20 ye tam bölünüyorsa
            //    {
            //        Console.WriteLine(sayilar[i]); // i yi yazdır

            //    }

            //}



            // Dizililerde toplama işlemi




            // DİZİ METODLARI

            // short metodu

            //int[] sayilar = { 1, 678, 85, 27, 776, 3 };

            //Array.Sort(sayilar); // Sayılarıküçükten büyüğe sıralamaya yarar

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}


            // Reverse metodu

            //string[] naber = { "selam", "canım", "naber" };

            //Array.Reverse(naber);
            //for (int i = 0; i < naber.Length; i++)
            //    {
            //       Console.WriteLine(naber[i]);
            //    }


            // Index of Metodu

            //string[] kisiler = { "Eren", "Dilara", "Buse", "Defne" };

            //int sira;

            //sira= Array.IndexOf(kisiler, "Eren");   // Kaçıncı indeks de oldupunu bulur

            //Console.Write(sira);



            // Foreach Döngüsü

            //string[] sehirler = { "bursa", "erzurum", "istanbul", "izmir" };

            //foreach (string s in sehirler)  // dizilerde kullanılan döngüdür
            //{   // değiken türü,değişken adı, in , dizi adı

            //    Console.WriteLine(s);

            //}

            // Foreach ile aritmetik işlemler

            //int[] sayi = { 1, 2, 65, 68, 245, 6 };

            //int toplam = 0;

            //foreach (int x in sayi)
            //{
            //    toplam=toplam+x;    
            //    Console.WriteLine(toplam);
            //}

            // Diziye klavyeden giriş yapmak


            string[] sehirler = new string[5];  // kaç veri girişi yapılacağını belirtiyoruz
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Şehir ismi: ");
                sehirler[i] = Console.ReadLine();

            }
            for (int j=0; j < 5;j++)
            {
                Console.WriteLine(sehirler[j]); // girilen verilerin dışa yazımı

            }









            Console.Read();

        }
    }
}
