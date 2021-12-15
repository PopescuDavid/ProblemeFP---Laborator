using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,n;
            Console.WriteLine("Dati a=");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati b=");
            b = int.Parse(Console.ReadLine());
            Console.Write($"Numerele perfecte din intervalul [{a},{b}] sunt ");
            for (int i=a;i<=b;i++)
            {
                if(Perfect(i))
                    Console.Write(i+" ");
            }
        }

        static bool Perfect(int n)
        {
            int suma = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                    suma = suma + i;
            }
            if (suma == n)
                return true;
            return false;
        }
    }
}
