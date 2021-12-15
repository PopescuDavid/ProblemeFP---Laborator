using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problema_51
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
        public static int[] NextIntArray(int length)
        {
            var next = new int[length];

        outsideLoop:
            while (true)
            {
                var input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    continue;
                }

                var split = Separator.Split(input.Trim());
                if (split.Length != length)
                {
                    Console.WriteLine($"Sirul trebuie sa aiba {length} element(e)!");
                    continue;
                }

                for (var i = 0; i < split.Length; i++)
                {
                    var str = split[i];

                    if (!int.TryParse(str, out var number))
                    {
                        Console.WriteLine(
                            "Te rugam sa te asiguri ca sirul contine valori de tip intreg separate printr-un spatiu!");
                        goto outsideLoop;
                    }

                    next[i] = number;
                }

                break;
            }

            return next;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti lungimea sirului:");
            var length = CRead.NextPositiveInt();

            Console.WriteLine("Introduceti elementele sirului separate printr-un spatiu:");
            var arr = CRead.NextIntArray(length);

            var min = arr[0];

            for (var i = 1; i < arr.Length; i++)
            {
                if (arr[i] >= min)
                {
                    continue;
                }

                min = arr[i];
            }

            Console.WriteLine();
            Console.WriteLine($"Elementul minim din vetorul dat este: {min}.");
        }
    }
}
