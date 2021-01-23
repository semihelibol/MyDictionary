using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string > iller = new MyDictionary<int, string>();
            iller.Add(12, "Bingöl");
            iller.Add(20, "Denizli");
            iller.Add(52,"Ordu");
            

            for (int i = 0; i < iller.Count; i++)
            {
                Console.WriteLine(iller.Keys[i]+" : "+iller.Values[i]);
            }

            Console.WriteLine("Toplam İl Sayısı: " + iller.Count);

        }
    }
}
