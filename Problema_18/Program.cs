using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_18
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
        public static double NextDouble()
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

                if (!parsed)
                {
                    Console.WriteLine("Te rugam introdu o valoare de tip dublu!");
                }
            }

            return next;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti valoarea lui a:");
            var a = CRead.NextDouble();
            Console.WriteLine("Introduceti valoarea lui b:");
            var b = CRead.NextDouble();

            Console.WriteLine("Ce doriti sa calculam? Media aritmetica (1) sau media geometrica (2)?");
            var input = Console.ReadLine();

            while (string.IsNullOrEmpty(input))
            {
                input = Console.ReadLine();
            }

            switch (input)
            {
                case "1":
                    Console.WriteLine();
                    Console.WriteLine($"Media aritmetica a lui {a} si {b}: {(a + b) / 2}");
                    break;
                case "2":
                    Console.WriteLine();
                    if (a <= 0 || b <= 0)
                    {
                        Console.WriteLine("eroare!");
                        return;
                    }
                    Console.WriteLine($"Media geometrica a lui {a} si {b}: {Math.Pow(a * b, 0.5)}");

                    return;
                default:
                    Console.Beep();
                    return;
            }
        }
    }
}
