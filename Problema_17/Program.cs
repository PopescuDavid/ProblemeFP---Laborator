using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_17
{
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
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti valoarea x0:");
            var x0 = CRead.NextUnsignedDouble();
            Console.WriteLine("Introduceti valoarea t0:");
            var t0 = CRead.NextUnsignedDouble();
            Console.WriteLine("Introduceti valoarea t:");
            var t = CRead.NextUnsignedDouble();
            Console.WriteLine("Introduceti valoarea x:");
            var x = CRead.NextUnsignedDouble();

            var distance = x - x0;
            var time = t - t0;

            if (distance < 0)
            {
                Console.WriteLine();
                Console.WriteLine("Distanta parcursa nu poate fi negativa.");
                return;
            }

            if (time <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("Durata nu poate fi mai mica sau egala cu 0.");
                return;
            }

            Console.WriteLine();
            Console.WriteLine(distance == 0
                ? "Punctul material nu se misca."
                : $"Viteza de miscare a punctului este {distance / time}");
        }
    }
}
