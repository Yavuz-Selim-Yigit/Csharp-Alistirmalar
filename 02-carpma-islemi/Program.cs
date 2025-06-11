using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Kullanıcıdan 2 adet int sayı alınız ve çarpınız.
sonucu ekrana yazdırınız.
*/


namespace _02_carpma_islemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, carpma;
            Console.Write("Lütfen birinci sayıyı giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            // Convert.ToInt32, kullanıcıdan alınan string değeri int'e çevirir.

            Console.Write("Lütfen ikinci sayıyı giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            carpma = sayi1 * sayi2;

            Console.WriteLine($"Çarpım sonucu: {carpma}");
        }
    }
}
