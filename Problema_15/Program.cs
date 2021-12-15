using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_15
{
    public static class MathHelper
    {

        public static BigInteger RecursiveFactorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), "Number can't be negative!");
            }

            return number == 0
                ? BigInteger.One
                : BigInteger.Multiply(RecursiveFactorial(number - 1), number);
        }

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

        public static BigInteger Choose(ushort n, ushort k)
        {
            if (k == 0) return 1;
            if (n == 0) return 0;

            return Choose((ushort)(n - 1), (ushort)(k - 1)) * n / k;
        }


    }
    class Program
    {
        public static class CRead
        {

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

        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti valoarea lui n:");
            var n = CRead.NextNaturalNumber();

            Console.WriteLine();
            Console.WriteLine($"{n}! = {MathHelper.Factorial(n)}");
        }
    }
}
