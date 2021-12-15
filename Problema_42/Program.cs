using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problema_42
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
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti valoarea numarului:");
            var number = CRead.NextPositiveInt();

            var root = Math.Round(Math.Pow(number, 1.0 / 3.0));

            Console.WriteLine();
            Console.WriteLine(Math.Abs(Math.Pow(root, 3) - number) < 0.0001
                ? $"{number} este un cub perfect."
                : $"{number} nu este un cub perfect.");
        }
    }
}
