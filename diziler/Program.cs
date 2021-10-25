using System;
using System.Collections.Generic;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dize = new int[10];

            Random rnd = new Random();
           for(int i = 0; i < dize.Length; i++)
            {
                dize[i] = rnd.Next(10, 100);
            }

            Array.Resize(ref dize, 5);

            foreach(int sayi in dize)
            {
                Console.WriteLine(sayi);
            }

            List<int> liste2 = new List<int>();


            //ÖNEMLİ!!!

            //value-değer-type-int,double,byte sabit değerler
            //refarence-type
            //string iki kalıbada uymuyo çünkü dinamik -immytable
            //bir değişkenin yanına null la eşitleyin eşitlenebiliyorsa refrance tipli
            // int a=5
            // int b=10
            //  a=b
            //   b=20
            //  a=?
            //  a =10 
            //ref
            //a[0]=5
            //b[0]=10
            //a=b
            //b[0]=10
            //a[0]=?
            //20.


        }
    }
}
