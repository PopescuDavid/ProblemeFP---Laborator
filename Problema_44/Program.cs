using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problema_44
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
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti valoarea numarului:");
            var number = CRead.NextInt();

            Console.WriteLine();
            Console.WriteLine($"Tabla inmultirii cu {number}:");
            Console.WriteLine();
            for (var i = 0; i <= number; i++)
            {
                long result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }
        }
    }
}
