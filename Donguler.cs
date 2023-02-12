using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // For Döngüsü

            /*
            int i;
            for(i=1; i<=10; i++) // i yi 1 den başlat; 10 a eşit olana kadar gelsin ve dursun; 1 artacak şekilde gelsin
            {
                Console.WriteLine("Selamlar");
            */


            // 0-20 arasındaki çift sayıları yazdır.
            /*
                        int i;
                        for(i=0; i<=20; i=i+2)
                        {
                            Console.WriteLine(i);
                        }

                        Console.Read();        

            */



            // 0-20 ye kadar 3'e bölünen sayıları yazdır.
            /*
                        int i;
                        for (i = 0; i <= 20; i++)
                        {
                            if (i%3==0) // i yi sürekli 3'e böl ve 0'a eşitle
                            {
                                Console.WriteLine(i);
                            }
                        }
                        Console.Read();

            */
            /*
                        // Tam bölenleri bulma
                        // 30 --> 1 2 3 5 6 10 15 30

                        int sayi;
                        Console.Write("Tam sayisini bulacağımız sayiyi giriniz: ");
                        sayi = Convert.ToInt32(Console.ReadLine());

                        int i;
                        for (i = 1; i <= sayi; i++)
                        {
                            if (sayi % i == 0)
                            {
                                Console.WriteLine(i);
                            }
                        }
            */

            //  Bir bakteri türü her saatin sonunda kendini 2'ye bölerek çoğalmaktadır.
            // Yeni oluşan bakteriler de aynı şekilde çoğalmaktadır. 24 saatin sonunda ortamda kaç bakteri olur
            /*
                        int i;
                        int bakteri = 1;
                        for (i = 1; i <= 24; i++)
                        {

                            bakteri = bakteri * 2;

                        Console.WriteLine(bakteri);

                        }

            */


            // Ardışık sayılarda işlemler


            //int toplam = 0; // Toplam adında bir değişken oluşturulur vce 0'a eşitlenir

            //for (int i = 0; i <= 10; i++)
            //{
            //    toplam = toplam + i ;

            //    Console.WriteLine(toplam);
            //}            //int toplam = 0; // Toplam adında bir değişken oluşturulur vce 0'a eşitlenir

            //for (int i = 0; i <= 10; i++)
            //{
            //    toplam = toplam + i ;

            //    Console.WriteLine(toplam);
            //}




            // 5 faktoriyel

            //int faktoriyel = 1;
            //int i;

            //for (i = 1; i <= 5; i++)
            //{

            //    faktoriyel = faktoriyel * i;

            //    Console.WriteLine(faktoriyel);

            //}




            // While Döngüsü

            //int sayac = 1;

            //while (sayac<=10)
            //{
            //    Console.WriteLine("Merhabalar arkadaşlar");
            //    sayac++;
            //}


            //int sayi = 1;
            //while (sayi<=10)
            //{
            //    Console.WriteLine(sayi);
            //    sayi++;
            //}


            // Soru: Klavyeden girilen sayının faktöriyelini while döngüsü ile hesaplayan kodu yazınız.


            //int sayi;
            //int i;
            //int faktoriyel=1;

            //Console.WriteLine("Bir sayı giriniz: ");
            //sayi = Convert.ToInt32(Console.ReadLine());


            //while (sayi>=1)
            //{
            //    faktoriyel = faktoriyel * sayi;
            //    sayi--;
            //}
            //Console.WriteLine(faktoriyel);



            // Do-While Döngüsü

            //int sayi = 1;

            //do
            //{
            //    Console.WriteLine("Selamlar canım");
            //    sayi++;

            //} while (sayi<=10);



















































            Console.Read();

        }
    }
}
