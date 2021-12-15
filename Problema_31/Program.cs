using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problema_31
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
            Console.WriteLine("Introduceti valoarea lui n:");
            var n = CRead.NextNaturalNumber();
            var numbers = new List<int>();

            for (var i = 2; i < n; i++)
            {
                if (!NumbersHelper.IsPrime(i))
                {
                    continue;
                }

                numbers.Add(i);
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine($"Nu exista numere mai mici decat {n} care sa fie prime.");
                return;
            }

            Console.WriteLine();
            Console.WriteLine($"Numerele prime mai mici decat {n} sunt:");
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
