using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problema_40
{
    public static class CRead
    {
        private static readonly Regex Separator = new Regex(" +");
        public static double NextUnsignedDouble()
        {
            var next = 0.0;
            var parsed = false;

            while (!parsed)
            {
                var input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    continue;
                }

                parsed = double.TryParse(input, out next);

                if (!parsed || next < 0)
                {
                    Console.WriteLine("Te rugam introdu o valoare de tip dublu mai mare sau egala cu 0!");
                }
            }

            return next;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti viteza automobilului:");
            var speed = CRead.NextUnsignedDouble();

            Console.WriteLine();
            Console.WriteLine($"Viteza automobilului in m/s este: {speed * (1000.0 / 3600.0)}");
        }
    }
}
