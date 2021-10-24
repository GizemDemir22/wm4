using System;

namespace odev2sekiller
{
    class Program
    {
        static void Main(string[] args)
        
            
            {
                Console.WriteLine("Ücgen Uzunluğunu Giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                
                int bosluksayisi = 1;
                for (int i = 0; i < sayi; i++)
                {
                    for (int j = 0; j < sayi - bosluksayisi - 1; j++)
                    {
                        Console.Write(" ");
                    }
                    if (i == 0)
                    {
                        Console.Write("x");
                    }
                    else if (i == sayi - 1)
                    {
                        for (int k = 0; k < i * 2; k++)
                        {
                            Console.Write("x");
                        }
                    }
                    else
                    {
                        Console.Write("x");
                        for (int l = 0;l< i * 2 - 1; l++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("x");
                    }
                    Console.WriteLine();
                    bosluksayisi++;
                }
                Console.ReadKey();
            //BAKLAVA
            int satir;
            Console.Write("Baklava diliminin boyutunu giriniz = ");
            satir = int.Parse(Console.ReadLine());

            //Baklava diliminin üst kısmını oluşturuyoruz.
            for (int i = 0; i <= satir; i++)
            {

                for (int j = 0; j <= (satir + 1) - i; j++)

                    Console.Write(" ");

                for (int k = 0; k <= 2 * i - 2; k++)

                    Console.Write("*");

                Console.WriteLine();

            }

            //Baklava diliminin alt kısmını oluşturuyoruz.
            for (int m = 0; m <= satir; m++)
            {

                for (int n = 0; n <= m; n++)

                    Console.Write(" ");

                for (int z = m * 2; z <= satir * 2; z++)

                    Console.Write("*");

                Console.WriteLine();

            }
            
            Console.ReadKey();
        }
    }
}
