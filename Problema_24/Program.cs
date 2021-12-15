using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problema_24
{
    public static class CRead
    {
        private static readonly Regex Separator = new Regex(" +");

        public static int NextNaturalNumber()
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

                if (!parsed || next < 0)
                {
                    Console.WriteLine("Te rugam introdu o valoare de tip intreg mai mare sau egala cu 0!");
                }
            }

            return next;
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti valoarea numarului:");
            var number = CRead.NextNaturalNumber();
            var copyNumber = number;

            var count = 0;
            while (copyNumber > 0)
            {
                count++;
                copyNumber /= 10;
            }

            Console.WriteLine();
            Console.WriteLine(count <= 1
                ? $"Numarul {number} are o cifra."
                : $"Numarul {number} are {count} cifre.");
        }
    }
}
