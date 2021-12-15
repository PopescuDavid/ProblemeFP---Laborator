using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problema_48
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
        public static int[][] NextIntMatrix(int length, int height)
        {
            var next = new int[length][];

            for (var i = 0; i < height; i++)
            {
                next[i] = new int[length];
            }

            for (var i = 0; i < height; i++)
            {
                var input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    i--;
                    continue;
                }

                var split = Separator.Split(input.Trim());
                if (split.Length != length)
                {
                    Console.WriteLine($"Lungimea matricii este {length}!");
                    i--;
                    continue;
                }

                for (var j = 0; j < split.Length; j++)
                {
                    var str = split[j];

                    if (!int.TryParse(str, out var number))
                    {
                        Console.WriteLine("Te rugam sa te asiguri ca valorile introduse sunt de tip intreg separate printr-un spatiu!");
                        i--;
                        break;
                    }

                    next[i][j] = number;
                }
            }

            return next;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti valoarea lui n:");
            var n = CRead.NextPositiveInt();

            Console.WriteLine("Introduceti elementele primei matrici, fiecare linie avanad elementele separate printr-un spatiu," +
                              " iar fiecare linie pe o linie noua.");
            var firstMatrix = CRead.NextIntMatrix(n, n);

            Console.WriteLine("Introduceti elementele celei de-a doua matrici, fiecare linie avnad elementele separate printr-un spatiu," +
                              " iar fiecare linie pe o linie noua.");
            var secondMatrix = CRead.NextIntMatrix(n, n);

            var finalMatrix = new int[n][];

            for (var i = 0; i < n; i++)
            {
                finalMatrix[i] = new int[n];
            }

            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    finalMatrix[i][j] = firstMatrix[i][j] + secondMatrix[i][j];
                }
            }

            Console.WriteLine();
            for (var i = 0; i < n; i++)
            {
                Console.WriteLine(string.Join(" ", finalMatrix[i]));
            }
        }
    }
}
