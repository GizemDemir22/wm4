using System;

namespace odevler1
{
    class Program
    {
        static void Main(string[] args)
        {
            //bom oyunu
            int pcSayi = 1;
            int kullaniciSayi;
            Console.Write("BOM sayısını giriniz:");
            int bom = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("oyun başlıyor...");
            Console.WriteLine("");
            while(pcSayi<101)
            {
                if (pcSayi % bom != 0) 
                {
                    Console.WriteLine(pcSayi);
                }
                else
                {
                    Console.WriteLine("BOM");
                }
                if ((pcSayi + 1) % bom == 0) 
                {
                    String text = Console.ReadLine().ToUpper();
                    if (text != "BOM") 
                    {
                        Console.WriteLine("PATLADINIZ!");
                        Environment.Exit(0);
                    }
                    else
                    {
                        pcSayi += 2;
                    }
                }
                else
                {
                    kullaniciSayi = Convert.ToInt32(Console.ReadLine());
                    if(kullaniciSayi!=pcSayi+1)
                    {
                        Console.WriteLine("PATLADINIZ!");
                        Environment.Exit(0);
                    }
                    else
                    {
                        pcSayi += 2;
                    }

                }
            }

            Console.WriteLine("BERABERE KALDINIZ.");

            Console.ReadKey();


        }
    }
}
