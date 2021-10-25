using System;

namespace ZarAtma
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            while (true)
            {
                Console.WriteLine("Zar sayısı girin:");
                try
                {
                    int zar = int.Parse(Console.ReadLine());

                    if(zar < 1 || zar > 6)
                    {
                        Console.WriteLine("1 ile 6 arası bir sayı girin");
                    }
                    else
                    {
                        int[] zarlar = new int[2] { 0, 0 };
                        int sayac = 0;

                        while(zarlar[0] != zar || zarlar[1] != zar)
                        {
                            zarlar[0] = rnd.Next(1, 7);
                            zarlar[1] = rnd.Next(1, 7);
                            sayac++;
                        }

                        Console.WriteLine(sayac + ". denemede bulundu.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
