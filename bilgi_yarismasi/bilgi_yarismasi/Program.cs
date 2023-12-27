using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilgi_yarismasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Turkcell Bilgi Yarışmasına Hoşgeldiniz");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();

            int soru = 1;
            string cevap;
            if(soru == 1)
            {
                Console.WriteLine("Türkiye'nin başkenti neresidir?");
                Console.WriteLine();
                Console.WriteLine("A)İstanbul");
                Console.WriteLine("B)Ankara");
                Console.WriteLine("C)İzmir");
                Console.WriteLine("D)Bursa");
                Console.WriteLine();
                Console.Write("Cevabınız:");
                cevap=Console.ReadLine();

                if(cevap=="b" || cevap=="B")
                {
                    soru = soru + 1;
                }
                else
                {
                    Console.Write("Cevap Yanlış toplam puanınız: 0");
                }
            }
            if(soru == 2)
            {
                Console.WriteLine("Cumhuriyet kaç yılında ilan edilmiştir?");
                Console.WriteLine();
                Console.WriteLine("A)1920");
                Console.WriteLine("B)1921");
                Console.WriteLine("C)1922");
                Console.WriteLine("D)1923");
                Console.WriteLine();
                Console.Write("Cevabınız:");
                cevap = Console.ReadLine();

                if (cevap == "d" || cevap == "D")
                {
                    soru = soru + 1;
                }
                else
                {
                    Console.Write("Cevabınız yanlış yarışma bitti toplam puanınız :1");
                }



            }
            if (soru == 3)
            {
                Console.WriteLine("Adana hangi coğrafi bölgemizdedir?");
                Console.WriteLine();
                Console.WriteLine("A)Akdeniz");
                Console.WriteLine("B)Marmara");
                Console.WriteLine("C)Karadeniz");
                Console.WriteLine("D)İç Anadolu");
                Console.WriteLine();
                Console.Write("Cevabınız:");
                cevap = Console.ReadLine();

                if (cevap == "a" || cevap == "A")
                {
                    Console.Write("Tebrikler yarışma bitti bütün soruları doğru bildiniz...");
                }
                else
                {
                    Console.Write("Cevabınız yanlış yarışma bitti toplam puanınız :2");
                }
            }

            Console.Read();
        }
    }
}
