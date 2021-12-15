using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problema_20
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
                Console.WriteLine("Introduceti secventa de numere cate unul pe fiecare linie:");
                var list = new List<int>();

                while (true)
                {
                    var newNumber = CRead.NextInt();

                    if (newNumber == 0)
                    {
                        break;
                    }

                    list.Add(newNumber);
                }

                if (list.Count == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Media aritmetica este 0.");
                    return;
                }

                Console.WriteLine();
                Console.WriteLine($"Media aritmetica este: {list.Aggregate(0D, (sum, number) => sum + number) / list.Count}");
            }
        }
}
