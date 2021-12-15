using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problema_25
{
    class Program
    {
        public static class CRead
        {
            private static readonly Regex Separator = new Regex(" +");

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
        public static class NumbersHelper
        {
            public static int Reverse(int number)
            {
                var sign = number < 0 ? -1 : 1;
                number = Math.Abs(number);

                var reverse = 0;
                while (number > 0)
                {
                    var remainder = number % 10;
                    reverse = reverse * 10 + remainder;
                    number /= 10;
                }

                return reverse * sign;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti valoarea numarului:");
            var number = CRead.NextInt();

            Console.WriteLine();
            Console.WriteLine(NumbersHelper.Reverse(number) != number
                ? $"{number} nu este palindrom."
                : $"{number} este palindrom.");
        }
    }
}
