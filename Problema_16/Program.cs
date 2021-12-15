using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_16
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
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul de foi:");
            var n = CRead.NextPositiveInt();
            Console.WriteLine("Introduceti numarul de randuri per foaie:");
            var r = CRead.NextPositiveInt();

            long total = n * r;
            Console.WriteLine();
            Console.WriteLine($"Cartea cu {n} pagini si {r} randuri per pagina are {total} randuri in total.");
        }
    }
}
