using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problema_38
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
    public static class MathHelper
    {
        public static BigInteger Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), "Number can't be negative!");
            }

            var result = BigInteger.One;

            for (var i = 1; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti valoarea lui n:");
            var n = CRead.NextNaturalNumber();

            Console.WriteLine();
            Console.WriteLine($"{n}! = {MathHelper.Factorial(n)}");
        }
    }
}
