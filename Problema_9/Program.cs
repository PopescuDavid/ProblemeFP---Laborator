using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("a= ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Cel mai mare divizor comun a lui {a} si {b} este {cmmdc(a,b)}");
            Console.WriteLine($"Cel mai mic multiplu comun a lui {a} si {b} este {a*b/cmmdc(a, b)}");
        }

        static int cmmdc(int a,int b)
        {
            if (a * b == 0) return a + b;
            if (a > b) return cmmdc(a - b, b);
            else return cmmdc(a, b - a);
        }
    }
}
