using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int  k;
            double i, j,putere;
            Console.Write("i= ");
            i = int.Parse(Console.ReadLine());
            Console.Write("j= ");
            j = int.Parse(Console.ReadLine());
            Console.Write("k= ");
            k = int.Parse(Console.ReadLine());
            putere = Math.Pow(i, j);
            Console.WriteLine($"Restul impartirii numarului {putere} la {k} este {putere%k}");
        }
    }
}
