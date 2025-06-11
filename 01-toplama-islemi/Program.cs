using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Kullanıcıdan double tipinde iki sayı alınız ve bu iki sayıyı toplayınız.
Toplam sonucunu virgülden sonra iki basamak olacak şekilde ekrana yazdırınız.
*/


namespace _01_toplama_islemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sayi1, sayi2, toplam;
            Console.Write("Lütfen birinci sayıyı giriniz: ");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            //Convert.ToDouble, kullanıcıdan alınan string değeri double'a çevirir.

            Console.Write("Lütfen ikinci sayıyı giriniz: ");
            sayi2 = Convert.ToDouble(Console.ReadLine());

            toplam = sayi1 + sayi2;

            Console.WriteLine("Toplam: {0:F2}", toplam);
            // F2 formatı virgülden sonra iki basamak gösterir
        }
    }
}
