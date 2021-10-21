using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //TAD-tipad=değer
            //tam sayı değişken tipleri
            short sayi = 32;
            int sayi2 = 32;
            sayi =(short) sayi2;

            //ondalık sayılar
            double sonuc = 7 / 2;
            Console.WriteLine(sonuc);

            //stringler
            string kelimne = "merhaba dünya";
            Console.WriteLine(kelimne);
            char sonHarf = 'z';
            Console.WriteLine(sonHarf);
            // mantıksal değişken tipi!!!

            bool isactive = true;
            isactive = !isactive;
            Console.WriteLine(isactive);

            DateTime tarih = DateTime.Now;
            Console.WriteLine(tarih.DayOfWeek);



            



           

            
        }
    }
}
