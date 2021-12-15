using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_28
{
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
            var numbers = new List<int>();

            for (var i = 100; i <= 999; i++)
            {
                if (!NumbersHelper.IsPrime(i) || !NumbersHelper.IsPrime(NumbersHelper.Reverse(i)))
                {
                    continue;
                }

                numbers.Add(i);
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Nu exista numere prime de 3 cifre care au inversul prim.");
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Numerele prime de 3 cifre care citite invers sunt tot prime sunt:");
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
