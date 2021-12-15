using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problema_56
{
    public static class CRead
    {
        private static readonly Regex Separator = new Regex(" +");
        public static int NextPositiveInt()
        {
            var next = 0;
            var parsed = false;

            while (!parsed)
            {
                var input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    continue;
                }

                parsed = int.TryParse(input, out next);

                if (parsed && next > 0)
                {
                    continue;
                }

                parsed = false;
                Console.WriteLine("Te rugam introdu o valoare de tip inreg pozitiva!");
            }

            return next;
        }
    }
        class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduceti lungimea sirului:");
            var length = CRead.NextPositiveInt();

            if (length == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Primul element din sirul lui Fibonacci este:");
                Console.WriteLine("1");
                return;
            }

            var arr = new int[length];

            arr[0] = 1;
            arr[1] = 1;
            for (var i = 2; i < length; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }

            Console.WriteLine();
            Console.WriteLine($"Primele {length} elemente din sirul lui Fibonacci sunt: ");
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
