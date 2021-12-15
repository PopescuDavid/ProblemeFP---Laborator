using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            if(Perfect(n))
                Console.WriteLine("Numarul n este perfect");
            else
                Console.WriteLine("Numarul n NU este perfect");
        }

        static bool Perfect(int n)
        {
            int suma = 0;
            for(int i=1;i<=n/2;i++)
            {
                if(n%i==0)
                    suma = suma + i;
            }
            if (suma == n)
                return true;
            return false;
        }
    }
}
