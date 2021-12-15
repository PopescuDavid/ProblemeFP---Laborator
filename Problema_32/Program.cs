using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problema_32
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

            var numbers = new List<int>();

            for (var i = 1; i <= n; i++)
            {
                if (MathHelper.RecursiveDigitSum(i) % 5 != 0)
                {
                    continue;
                }

                numbers.Add(i);
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine($"Nu exista numere mai mici sau egale cu {n} care au suma cifrelor divizibila cu 5.");
                return;
            }

            Console.WriteLine();
            Console.WriteLine($"Numerele mai mici sau egale cu {n} care au suma cifrelor divizibila cu 5 sunt:");
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
