using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Primele {n} numere prime sunt: ");
            for(int i=1;i<=n;i++)
                if(prim(i))
                    Console.Write(i+" ");
        }

        static bool prim(int n)
        {
            if (n < 2 || n%2==0)
                return false;
            if (n == 2)
                return true;
            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0)
                    return false;
            return true;
        }
    }
}
