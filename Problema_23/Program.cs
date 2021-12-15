using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problema_23
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
            Console.WriteLine("Introduceti valoarea primului numar:");
            var first = CRead.NextInt();
            Console.WriteLine("Introduceti valoarea celui de-al doilea numar:");
            var second = CRead.NextInt();

            if (second == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Impartirea nu se poate face la 0!");
                return;
            }

            if (first == 0)
            {
                Console.WriteLine();
                Console.WriteLine($"Rezultatul impartirii: {first} / {second} = 0");
                return;
            }

            var sign = 1;
            if (first * second < 0)
            {
                sign = -1;
            }

            var absSecond = Math.Abs(second);

            var integer = 0;

            var remainder = Math.Abs(first);

            while (remainder >= absSecond)
            {
                remainder -= absSecond;
                integer++;
            }

            integer *= sign;

            Console.WriteLine();
            Console.WriteLine(remainder == 0
                ? $"Rezultatul impartirii {first} / {second} = {integer}"
                : $"Rezultatul impartirii {first} / {second} = {integer} r {remainder}");
        }
    }
}
