using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problema_30
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
        public static bool IsInBase(int number, int numberBase)
        {
            if (numberBase < 2 || numberBase > 10)
            {
                throw new ArgumentOutOfRangeException(nameof(numberBase), $"Invalid base value: {numberBase}. Valid interval: [2, 10]");
            }
            while (number > 0)
            {
                if (number % 10 >= numberBase)
                {
                    return false;
                }
                number /= 10;
            }

            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti valoarea bazei (numar din intervalul [2, 9]):");
            var p = CRead.NextPositiveInt();
            while (p < 2 || p > 9)
            {
                Console.WriteLine("Baza poate fi doar o valoare din intervalul [2, 9]!");
                p = CRead.NextPositiveInt();
            }

            Console.WriteLine("Introduceti un numar in baza 10:");
            var base10Number = Math.Abs(CRead.NextInt());
            Console.WriteLine($"Introduceti un numar in baza {p}");
            var otherBaseNumber = Math.Abs(CRead.NextInt());

            while (!NumbersHelper.IsInBase(otherBaseNumber, p))
            {
                Console.WriteLine($"Numarul trebuie sa fie in baza {p}.");
                otherBaseNumber = CRead.NextInt();
            }

            var builder = new StringBuilder();
            var copyBase10Number = base10Number;

            if (base10Number == 0)
            {
                builder.Append(0);
            }

            while (copyBase10Number > 0)
            {
                var remainder = copyBase10Number % p;
                builder.Append(remainder);
                copyBase10Number /= p;
            }

            Console.WriteLine();
            Console.WriteLine($"{base10Number} din baza 10 in baza {p} este: {string.Join("", builder.ToString().Reverse())}");

            var result = 0;
            var copyOtherBaseNumber = otherBaseNumber;
            var i = 0;
            while (copyOtherBaseNumber > 0)
            {
                result += (int)(copyOtherBaseNumber % 10 * Math.Pow(p, i));
                copyOtherBaseNumber /= 10;
                i++;
            }

            Console.WriteLine($"{otherBaseNumber} din baza {p} in baza 10 este: {string.Join("", result)}");
        }
    }
}
