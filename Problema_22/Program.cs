using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problema_22
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
        class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti valoarea primului numar:");
            var first = CRead.NextNaturalNumber();
            Console.WriteLine("Introduceti valoarea celui de-al doilea numar:");
            var second = CRead.NextNaturalNumber();

            var result = 0;

            for (var i = 0; i < second; i++)
            {
                result += first;
            }

            Console.WriteLine();
            Console.WriteLine($"Rezultatul inmultirii: {first} * {second} = {result}");
        }
    }
}
