using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, matm, marm, suma = 0, nr = 0,suma2=0;
            double produs = 1,mg;
            Console.Write("a= ");
            a = int.Parse(Console.ReadLine());
            for(int i=1;i<=a/2;i++)
            {
                if(a%i==0)
                {
                    suma = suma + i;
                    nr++;
                    produs = produs * i;
                    suma2 = suma2 + 1 / i;
                }
            }
            matm = suma / nr;
            mg = Math.Sqrt(produs);
            marm = nr / suma2;
            Console.WriteLine($"Media aritmetica este {matm}");
            Console.WriteLine($"Media geometrica este {mg}");
            Console.WriteLine($"Media armonica este {marm}");
        }
    }
}
