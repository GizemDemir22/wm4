using System;

namespace wm4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("adınızı giriniz: ");
            string ad = Console.ReadLine();
            Console.WriteLine();

            /*
                *kullanıcıgirişleri
                *veritabanı işlemleri
                *dosya işlemleri
                *sunucu istekleri
                *tür dönüşümleri
                *
                *try-Catch| error handling
                */



            Console.Write("lütfen 1 ile 100 arası bir sayı giriniz: ");
            int girilensayi = 0;
            try 
            {
                girilensayi = Convert.ToInt32(Console.ReadLine());

                if(girilensayi<1|| girilensayi>100)
                {
                    throw new Exception(message :"girilen sayı 1-100 arasında değil");
                }
                Console.WriteLine(girilensayi*girilensayi);
            }
            catch (OverflowException ex1)
            {
                Console.WriteLine("girilen sayı .ok büyük yada .ok küçük");
            }
            catch(FormatException ex2)
            {
                Console.WriteLine("lütfen bir sayı giriniz");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("finaly çalıştı");
            int sayi2 = 0;
            string girilen = Console.ReadLine();
            if(int.TryParse(girilen, out sayi2))
            {
                Console.WriteLine(sayi2 * sayi2);

            }
            else
            {
                Console.WriteLine("bir sayı girmeyi beceremedin");
            }
            

        }
    }
}
