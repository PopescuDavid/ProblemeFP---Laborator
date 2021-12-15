using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, r,a,b;
            Console.Write("x= ");
            x = int.Parse(Console.ReadLine());
            Console.Write("y= ");
            y = int.Parse(Console.ReadLine());
            r = x % y;
            a = x;
            b = y;
            while(r!=0)
            {
                x = y;
                y = r;
                r = x % y;
            }
            if(y==1)
                Console.WriteLine($"Numerele {a} si {b} sunt prime intre ele");
            else
                Console.WriteLine($"Numerele {a} si {b} NU sunt prime intre ele");
        }
    }
}
