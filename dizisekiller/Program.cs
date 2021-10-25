using System;

namespace dizisekiller
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] matris = null;
            try
            {
   
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            int x = matris.GetLength(dimension: 0);  
            int y = matris.GetLength(dimension: 1);
            Console.Write("lütfen boyutu girin : ");
            int girilenBoyut = int.Parse(Console.ReadLine());
            matris = new bool[girilenBoyut,2 * girilenBoyut-1];
            for (int satir = 0; satir >= 0; satir --)
            {
                for (int sutun = 0; sutun < matris.GetLength(dimension: 1); sutun++)
                {
                    matris[satir, sutun] = true;
                    int boslukSayisi = (x - 1 - satir) * 2;
                    for (int   i= 0;  i< boslukSayisi; i ++)
                    {

                    }
                    {
                        matris[satir, sutun] = true;
                    }
                }
            }
            //ekrana yazdır
             for(int satir=0; satir< matris.GetLength(dimension:0);satir++)
                for (int sutun=0; sutun<matris.GetLength(dimension:1); sutun++)
                {
                    Console.Write(matris[satir, sutun] ? "x" : " ");
                }
            Console.WriteLine();
        }
    }
}
