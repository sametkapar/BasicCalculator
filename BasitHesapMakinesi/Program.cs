using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BasitHesapMakinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-*-*-BASİT HESAP MAKİNESİ-*-*-");
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz topla/çıkar/çarp/böl");
            string islem = Console.ReadLine();
            islem = islem.ToUpper();
            Console.Write("1. sayı giriniz: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2. sayıyı giriniz: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            double sonuc;

            if (islem == "TOPLA")
            {
                sonuc = sayi1 + sayi2;
                Console.WriteLine("Sayıların toplamı = " + sonuc);
            }
            else if (islem == "ÇIKAR")
            {
                sonuc = sayi1 - sayi2;
                Console.WriteLine("Sayıların farkı = " + sonuc);
            }
            else if (islem == "BÖL")
            {
                sonuc = sayi1 / sayi2;
                Console.WriteLine("Sayılarının bölümü = " + sonuc);
                if (sayi2 == 0)
                {
                    Console.WriteLine("Sıfıra bölünemez");
                }
            }else if(islem == "ÇARP")
            {
                sonuc = sayi1 / sayi2;
                Console.WriteLine("Sayıların çarpımı = " + sonuc);
            }
            else
            {
                Console.Beep();
            }


        }
    }
}
