using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problema_35
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
        public static int NextInt()
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

                if (!parsed)
                {
                    Console.WriteLine("Te rugam introdu o valoare de tip intreg!");
                }
            }

            return next;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduceti valoarea lui n:");
            var n = CRead.NextNaturalNumber();

            while (n >= 1_000_000_000)
            {
                Console.WriteLine(
                    "Valoarea lui n nu poate avea mai mult de 9 cifre! Introduceti o valoare noua:");
                n = CRead.NextInt();
            }



            // todo solve this.
            Console.WriteLine();
        }
    }
}
