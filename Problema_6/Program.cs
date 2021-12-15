using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Dati a=");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati b=");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Numerele prietene din intervalul [{a},{b}] sunt: ");
            for(int i=a;i<b;i++)
            {
                for(int j=i+1;j<=b;j++)
                {
                    if(sumDiv(i)==sumDiv(j))
                        Console.WriteLine($"{i},{j}");
                }
            }
        }

        static int sumDiv(int n)
        {
            int suma = 0;
            for(int i=1;i<=n/2;i++)
            { if (n % i == 0) suma = suma + i; }
            return suma;
        }
    }
}
