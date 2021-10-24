using System;

namespace karar_yapıları
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isactive = true;
            if (isactive)
            {
                Console.WriteLine("aktif");
            }
            else
            {
                Console.WriteLine("aktif değil");
            }

            // else if
            int not = 69;


            if (not >= 70)
            {
                Console.WriteLine("geçti");

            } else if (not < 70 & not > 50) 
            {
                Console.WriteLine("orta");
            }else if (not<=50 & not>30)
            {
                Console.WriteLine("geçerli");
            }
            else
            
            {
                Console.WriteLine("kaldı");

            }

            //switch-case

            string sonuc = "pazar";
            switch(sonuc)
            {
                case "pazartesi":
                    Console.WriteLine("pazartesi");
                    break;
                case "salı":
                    Console.WriteLine("salı");
                    break;

                default:

                    Console.WriteLine("geçersiz gün");
                    break;

                 

            }

            //donguler
            //while

            DateTime tarih = DateTime.Now;
            int gunsayisi = 0;
            int sayac = 0;

            while (gunsayisi < 100)
            {
                DateTime sonrakigun = tarih.AddDays(sayac);
                sayac++;
                if (sonrakigun.DayOfWeek == DayOfWeek.Saturday || sonrakigun.DayOfWeek == DayOfWeek.Sunday)
                    continue;
                Console.WriteLine(sonrakigun);
                gunsayisi++;

                //do while
                
                    sayac = 0; gunsayisi = 0;
                do
                {
                    sonrakigun = tarih.AddDays(sayac);
                    sayac++;
                    if 
              
                       (sonrakigun.DayOfWeek == DayOfWeek.Saturday || sonrakigun.DayOfWeek == DayOfWeek.Sunday)
                        continue;
                    Console.WriteLine(sonrakigun);
                    gunsayisi++;
                } while (gunsayisi < 100);

                //break continue return

                for (int i = 0; i < 1000; i++)
                {
                    Console.WriteLine(i);
                }


            }

        }
    }
}
