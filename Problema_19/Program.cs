using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_19
{
    class Program
    {
        public static class CRead
        {

      
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
        public static class NumbersHelper
        {
            public static bool CanBeTriangle(double first, double second, double third)
            {
                return first + second > third && first + third > second && second + third > first;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti valoarea lui a:");
            var a = CRead.NextUnsignedDouble();
            Console.WriteLine("Introduceti valoarea lui b:");
            var b = CRead.NextUnsignedDouble();
            Console.WriteLine("Introduceti valoarea lui c:");
            var c = CRead.NextUnsignedDouble();

            if (!NumbersHelper.CanBeTriangle(a, b, c))
            {
                Console.WriteLine();
                Console.WriteLine("Cele trei valori nu pot forma un triunghi.");
                return;
            }

            Console.WriteLine("Ce doriti sa calculam? Aria sau permietrul?");
            var input = Console.ReadLine();

            while (string.IsNullOrEmpty(input))
            {
                input = Console.ReadLine();
            }

            var perimeter = a + b + c;

            while (true)
            {
                switch (input.ToLower())
                {
                    case "aria":
                    case "arie":
                        var area = Math.Sqrt(perimeter / 2 * (perimeter / 2 - a) * (perimeter / 2 - b) * (perimeter / 2 - c));
                        Console.WriteLine();
                        Console.WriteLine($"Aria este: {area}.");
                        return;
                    case "perimetru":
                    case "permietrul":
                        Console.WriteLine();
                        Console.WriteLine($"Perimetrul este: {perimeter}");
                        return;
                    default:
                        Console.WriteLine("Te rugam sa selectezi un raspuns valid: aria sau perimetrul.");
                        break;
                }
            }
        }
    }
}
