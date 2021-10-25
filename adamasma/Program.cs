using System;
using System.Collections.Generic;
using System.Linq;

namespace adamasma
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Oyun oynamak ister misin? e=evet");

                char yesno = Convert.ToChar(Console.ReadLine().ToLower());
                if(yesno == 'e')
                {
                    AdamAsmaca();
                }
                else
                {
                    break;
                }
            }
        }

        static void AdamAsmaca()
        {
            //Kelimeler adında bir dizi oluşturup tahmin edilecek kelimeleri içine giriyoruz
            string[] kelimeler = new string[10]
            {
                "kelime",
                "istanbul",
                "masa",
                "araba",
                "bilgisayar",
                "televizyon",
                "defter",
                "kalem",
                "telefon",
                "ömer"
            };

            //Rastgele bir kelime seçimi yapıyoruz
            Random rastgele = new Random();
            int index = rastgele.Next(9);
            string kelime = kelimeler[index];

            //kullanıcının hak ve puanını tanımlıyoruz
            int hak = 5;
            int puan = 0;

            //kullanıcının yaptığı doğru tahminleri atayacağımız listeyi oluşturuyoruz.
            List<char> tahminler = new List<char>();

            while (true)
            {
                //Harf tahminleri bittiğinde sonuçta "-" olmaması gerekir. Sonucu bu değişkene atıyoruz.
                string sonuc = "";

                Console.WriteLine("Harf ya da kelime girerek tahminde bulunun.");
                foreach (char b in kelime)
                {
                    if (tahminler.Contains(b))
                    {
                        Console.Write(b);
                        sonuc += b;
                    }
                    else
                    {
                        Console.Write("-");
                        sonuc += "-";
                    }
                }
                Console.WriteLine();

                if (!sonuc.Contains("-"))
                {
                    Console.WriteLine("Tebrikler bildiniz!");
                    Console.WriteLine("Puanınız: " + puan);
                    break;
                }

                try
                {
                    //Kullanıcının hakkı kalmadıysa çıkış yap
                    if (hak == 0)
                    {
                        Console.WriteLine("Hakkınız kalmadı.");
                        Console.WriteLine("Doğru kelime: " + kelime);
                        Console.WriteLine("Puanınız: " + puan);
                        break;
                    }

                    //kullanıcıdan tahmin al
                    string tahmin = Console.ReadLine().ToLower();

                    //tahmin harf mi yoksa kelime mi diye kıyasla
                    if (tahmin.Length == 1) //harf ise
                    {
                        char c = Convert.ToChar(tahmin);

                        //harf seçili kelimede varsa ve doğru tahmin listesinde yoksa
                        //Contains ile array veya listede eleman aranır
                        if (kelime.Contains(c) && !tahminler.Contains(c))
                        {
                            tahminler.Add(c);
                            puan += kelime.Length * 10;
                        }
                        else //yanlış tahmin yapıldıysa
                        {
                            puan -= (puan * 15 / 100); //%15 düşür
                            hak--;
                            Console.WriteLine("kalan hakkınız: " + hak);
                        }
                    }
                    else if (tahmin.Length > 1) //kelimeyse
                    {
                        if (kelime.ToLower() == tahmin) //doğru tahminse
                        {
                            puan += kelime.Length * 10;
                            Console.WriteLine("Tebrikler bildiniz!");
                            Console.WriteLine("Puanınız: " + puan);
                            break;
                        }
                        else //yanlış tahmin yaptıysa
                        {
                            puan -= (puan * 15 / 100);
                            hak--;
                            Console.WriteLine("kalan hakkınız: " + hak);
                        }
                    }
                    else //Harf veya kelime değilse kullanıcıyı uyar
                    {
                        Console.WriteLine("Yalnızca harf veya kelime girin!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        static int Toplama(int a, int b)
        {
            //işlemler
            //...

            return a + b;
        }

        static void yazdir()
        {
            Console.WriteLine("Program çalıştı");
        }
    }
}
