using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            Console.Write("k= ");
            k = int.Parse(Console.ReadLine());
            int factn = 1, factk = 1, factnk = 1;
            for (int i = 1; i <= n; i++)
                factn = factn * i;
            for (int i = 1; i <= k; i++)
                factk = factk * i;
            for (int i = 1; i <= n-k; i++)
                factnk = factnk * i;
            int nCk = factn / (factk * factnk);
            Console.WriteLine(nCk);
        }
    }
}
