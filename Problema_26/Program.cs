using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problema_26
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
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti valoarea lui m:");
            var m = CRead.NextPositiveInt();

            if (m <= 1)
            {
                Console.WriteLine();
                Console.WriteLine("Nu exista numere prime mai mici sau egale cu 1.");
                return;
            }

            var numbers = new List<int>();

            for (var i = 2; i <= m; i++)
            {
                if (NumbersHelper.IsPrime(i))
                {
                    numbers.Add(i);
                }
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine($"Nu exista numere prime mai mici sau egale cu {m}");
                return;
            }

            Console.WriteLine();
            Console.WriteLine($"Numerele prime mai mici sau egale cu {m} sunt:");
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
