using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Problema_14
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
        }
            static void Main(string[] args)
            {
                Console.WriteLine("Introduceti secventa de numere cate unul pe fiecare linie:");
                var newNumber = CRead.NextInt();

                var min = newNumber;
                var max = newNumber;

                if (newNumber == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Cel mai mic numar: {min}, iar cel mai mare numar: {max}.");
                    return;
                }

                while (true)
                {
                    newNumber = CRead.NextInt();

                    if (newNumber < min)
                    {
                        min = newNumber;
                    }

                    if (newNumber > max)
                    {
                        max = newNumber;
                    }

                    if (newNumber == 0)
                    {
                        break;
                    }
                }

                Console.WriteLine();
                Console.WriteLine($"Cel mai mic numar: {min}, iar cel mai mare numar: {max}.");
            }
    }
}
