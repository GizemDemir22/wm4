using System;

namespace ODEV2ŞEKİLLER
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ücgen Uzunluğunu Giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            int bosluksayisi = 1;
            for (int i = 0; i < sayi; i++)
            {
                for (int j = 0; j < sayi - bosluksayisi - 1; j++)
                {
                    Console.Write(" ");
                }
                if (i == 0)
                {
                    Console.Write("o");
                }
                else if (i == sayi - 1)
                {
                    for (int k = 0; k < i * 2; k++)
                    {
                        Console.Write("¯");
                    }
                }
                else
                {
                    Console.Write("/");
                    for (int l = 0;< i * 2 - 1; l++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(@"\");
                }
                Console.WriteLine();
                bosluksayisi++;
            }
            Console.ReadKey();

        }
    }
}
