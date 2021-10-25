using System;

namespace gün3
{
    class Program
    {
        static void Main(string[] args)
        {

            //arrays-diziler
            //aynı tipten birden fazla değeri tutabildiğimşz veri tiplerine dizi adını veriyoruz.
            // ındex 0 dan başlar.
            int sayi = 0; sayi = 0;
            int[] sayilar = new[] { 3, 5, 6, 69,7,9,8 };
            sayilar = new int[10];

            sayilar[0] = 3;
            sayilar[1] = 5;
            sayilar[2] = 6;
            sayilar[3] = 69;

            Console.WriteLine(sayilar.Length);
            Random rnd = new Random();
            for(int i=0; 1<sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(maxValue :100);
            }
            foreach(int i in sayilar)
            {
                Console.WriteLine(i);
            }

        }
    }
}
