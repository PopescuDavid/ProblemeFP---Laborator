using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_47
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var arr = new int[100];

            for (var i = 0; i < 100; i++)
            {
                arr[i] = random.Next(0, 99);
            }

            var frequency = new int[100];

            for (var i = 0; i < 100; i++)
            {
                frequency[arr[i]]++;
            }

            var result = new List<int>();

            for (var i = 0; i < 100; i++)
            {
                if (frequency[i] > 1)
                {
                    result.Add(i);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Sirul generat aleatoriu este:");
            Console.WriteLine(string.Join(", ", arr));

            Console.WriteLine();
            Console.WriteLine("Elementele din sir care se repeta sunt:");
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
