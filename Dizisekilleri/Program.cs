using System;

namespace Dizisekilleri
{
    class Program
    {
        static void Main(string[] args)
        {

            UcgenCiz();

        }

        static void UcgenCiz()
        {

            bool[,] matris = null;
            try
            {
                Console.Write("Lütfen Boyutu Girin: ");
                int girilenBoyut = int.Parse(Console.ReadLine());
                matris = new bool[girilenBoyut, 2 * girilenBoyut - 1];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            for (int satir = 0; satir < matris.GetLength(0); satir++)
            {
                for (int sutun = 0; sutun < matris.GetLength(1); sutun++)
                {
                    if ((satir + sutun >= matris.GetLength(0) - 1 && sutun - satir <= matris.GetLength(0) - 1))
                    {
                        matris[satir, sutun] = true;
                    }
                }

            }

            //ekrana yazdır

            for (int satir = 0; satir < matris.GetLength(0); satir++)
            {
                for (int sutun = 0; sutun < matris.GetLength(1); sutun++)
                {
                    Console.Write(matris[satir, sutun] ? "X" : " ");
                }
                Console.WriteLine();
            }
        }
    }
}
