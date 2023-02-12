using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yarisma_Proje
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*
                        ----- KURALLAR -----

            - Toplam soru sayısı: 3
            - Her sayıdaki şık sayısı: 4
            - Diğer soruya geçebilmek için doğru cevap vermek gerekiyor
            - Yanlış cevap verilince yarışma sona erer.
            - 3 sorunun tamamı doğru cevaplanırsa oyun biter.

            */

            string isim,soru1,cevap1,cevap1a, cevap1b, cevap1c, 
                cevap1d,soru2,cevap2,cevap2a,cevap2b,cevap2c,cevap2d, soru3, cevap3, cevap3a, cevap3b, cevap3c, cevap3d;

            Console.Write("Yarışmamıza hoş geldiniz. Lütfen kayıt olmak için ad-soyad bilgilerinizi giriniz; ");
            isim = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Sayın "+isim+" yarışmamıza hoş geldiniz. Toplam 3 soru sonunda büyük ödüle ulaşacaksınız");
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Hazırsanız ilk sorumuz geliyor...");
            Console.WriteLine();
            Console.WriteLine();



            soru1 = "Fenerbahçenin kaç şampiyonluğu var?";
            cevap1a = "a";
            cevap1b = "b";
            cevap1c = "c";
            cevap1d = "d";
            soru2 = "Erenin doğum günü ne zaman?";
            cevap2a = "a";
            cevap2b = "b";
            cevap2c = "c";
            cevap2d = "d";
            soru3 = "8+6/2 ?";
            cevap3a = "a";
            cevap3b = "b";
            cevap3c = "c";
            cevap3d = "d";

            Console.WriteLine(soru1);
            Console.WriteLine(cevap1a + "-) 19");
            Console.WriteLine(cevap1b + "-) 28");
            Console.WriteLine(cevap1c + "-) 22");
            Console.WriteLine(cevap1d + "-) 36");
            Console.WriteLine();

            Console.WriteLine("Cevabınızı a,b,c,d şeklinde giriniz");
            cevap1 = Console.ReadLine();

            
            if(cevap1==cevap1a)
            {
                Console.WriteLine("Tebrikler doğru bildiniz sonraki cevaba geçebilirsiniz");


                Console.WriteLine(soru2);
                Console.WriteLine(cevap2a + "-) 29.01.2004");
                Console.WriteLine(cevap2b + "-) 23.06.2000");
                Console.WriteLine(cevap2c + "-) 16.12.1999");
                Console.WriteLine(cevap2d + "-) 03.01.2002");
                Console.WriteLine();
                Console.WriteLine("Cevabınızı a,b,c,d şeklinde giriniz");
                cevap2 = Console.ReadLine();

                if(cevap2==cevap2a)
                {
                    Console.WriteLine("Tebrikler doğru bildiniz sonraki cevaba geçebilirsiniz");

                    Console.WriteLine(soru3);
                    Console.WriteLine(cevap3a + "-) 16");
                    Console.WriteLine(cevap3b + "-) 8");
                    Console.WriteLine(cevap3c + "-) 12");
                    Console.WriteLine(cevap3d + "-) 7");
                    Console.WriteLine();
                    Console.WriteLine("Cevabınızı a,b,c,d şeklinde giriniz");
                    cevap3 = Console.ReadLine();

                    if(cevap3==cevap3c)
                    {
                        Console.WriteLine("Tebrikler doğru bildiniz. Büyük ödülün sahibisiniz");
                    }
                    else
                    {
                        Console.WriteLine("Doğru cevap 'c' seçeneğiydi, kaybettiniz.");

                    }

                }
                else
                {
                    Console.WriteLine("Doğru cevap 'a' seçeneğiydi, kaybettiniz.");
                }

            }
            else
            {
                Console.WriteLine("Doğru cevap 'a' seçeneğiydi, kaybettiniz.");
            }
    

                Console.Read();
        }
    }
}
