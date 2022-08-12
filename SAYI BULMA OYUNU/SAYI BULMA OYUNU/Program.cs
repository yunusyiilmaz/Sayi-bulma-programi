using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAYI_BULMA_OYUNU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            int sayi;
            Random değer=new Random();
           sayi = değer.Next(1, 100);
            int tahmin =0;
            while(sayac<5)
            {
                Console.Write("SAYIYI TAHMİN EDİNİZ :");
                tahmin=Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine();
                if (tahmin < sayi)
                {
                    Console.WriteLine("daha büyük bir değer giriniz\n");
                }
                else if (tahmin > sayi)
                {
                    if (tahmin != sayi)
                    {

                        if (sayac == 4)
                        {
                            Console.WriteLine("sayıyı bilemediniz sayı :" + sayi);
                            break;
                        }
                        Console.WriteLine("daha küçük bir sayı girin\n");                       
                    }
                }
            
                else if (tahmin == sayi)
                {
                    Console.WriteLine("tebrikler.");
                    break;
                }
                sayac++;
            }
            
            Console.ReadKey(); 

        }
    }
}
