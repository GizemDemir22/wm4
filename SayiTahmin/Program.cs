using System;

namespace SayiTahmin
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int sayi = rnd.Next(1, 100);

            Console.WriteLine("Sayı girin:");

            while (true)
            {
                try
                {
                    int tahmin = int.Parse(Console.ReadLine());
                    if (tahmin == sayi)
                    {
                        Console.WriteLine("tebrikler bildiniz.");
                        Console.WriteLine("tekrar oynamak ister misiniz?  e/h");

                        string yes = Console.ReadLine();
                        if (yes.ToLower() != "e")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Sayı girin:");
                            sayi = rnd.Next(1, 100);
                        }
                            
                    }
                    else if (tahmin < sayi)
                        Console.WriteLine("daha büyük sayı girin");
                    else
                        Console.WriteLine("daha küçük sayı girin");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Sayı girin:");
                }
            }
        }
    }
}
