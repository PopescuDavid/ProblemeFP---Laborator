using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problema_21
{

    public static class CRead
    {
        private static readonly Regex Separator = new Regex(" +");

        /// <summary>
        /// Reads the next line of characters from the standard input stream and casts it to <see cref="int"/>.
        /// </summary>
        /// <remarks>
        /// The method will keep asking for a valid value if the input cannot be casted to int
        /// and only returns when it finds a valid input.
        /// </remarks>
        /// <returns>The value that was read from console</returns>
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
        public static int[] NextNaturalNumbersArray(int length)
        {
            var next = new int[length];

        outsideLoop:
            while (true)
            {
                var input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    continue;
                }

                var split = Separator.Split(input.Trim());
                if (split.Length != length)
                {
                    Console.WriteLine($"Sirul trebuie sa aiba {length} element(e)!");
                    continue;
                }

                for (var i = 0; i < split.Length; i++)
                {
                    var str = split[i];

                    if (!int.TryParse(str, out var number) || number < 0)
                    {
                        Console.WriteLine(
                            "Te rugam sa te asiguri ca sirul contine valori de tip intreg mai mari sau egale cu 0 separate printr-un spatiu!");
                        goto outsideLoop;
                    }

                    next[i] = number;
                }

                break;
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
            Console.WriteLine("Introduceti valoarea lui p:");
            var p = CRead.NextNaturalNumber();
            Console.WriteLine("Introduceti valoarea lui k:");
            var k = CRead.NextNaturalNumber();
            Console.WriteLine("Introduceti elementele sirului de numere separate printr-un spatiu:");
            var arr = CRead.NextNaturalNumbersArray(n);

            Console.WriteLine();
            Console.WriteLine($"Din sirul dat, {arr.Count(i => i % p == k)} element(e) dau rest {k} cand sunt impartite la {p}.");
        }
    }
}
