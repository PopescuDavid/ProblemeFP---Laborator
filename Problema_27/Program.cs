using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problema_27
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
    public static class NumbersHelper
    {
        public static bool IsPrime(int number)
        {
            if (number == 2) return true;

            if (number <= 1) return false;
            if (number % 2 == 0) return false;

            var squareRoot = (int)Math.Floor(Math.Sqrt(number));

            for (var i = squareRoot; i >= 3; i--)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
    public static class MathHelper
    {
        public static long RecursiveDigitSum(long number)
        {
            number = Math.Abs(number);
            if (number == 0)
            {
                return 0;
            }

            return number % 10 + RecursiveDigitSum(number / 10);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti valoarea lui n:");
            var n = CRead.NextPositiveInt();
            Console.WriteLine("Introduceti valoarea lui m:");
            var m = CRead.NextPositiveInt();

            var numbers = new List<int>();
            var index = 2;
            while (numbers.Count < n)
            {
                if (!NumbersHelper.IsPrime(index))
                {
                    index++;
                    continue;
                }

                if (MathHelper.RecursiveDigitSum(index) > m)
                {
                    break;
                }

                numbers.Add(index);

                index++;
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine($"Nu exista numere prime care sa aiba suma cifrelor mai mica sau egala cu {m}.");
                return;
            }

            Console.WriteLine();
            Console.WriteLine(n == 1
                ? $"Primul numar prim care are suma cifrelor mai mica sau egala cu {m}:"
                : $"Primele {n} numere prime care au suma cifrelor mai mica sau egala cu {m}:");
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
