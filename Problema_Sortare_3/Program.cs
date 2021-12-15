using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problema_Sortare_3
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
        public static int[] NextNaturalNumbersArray(int length)
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

                    if (!int.TryParse(str, out var number) || number < 0)
                    {
                        Console.WriteLine(
                            "Te rugam sa te asiguri ca sirul contine valori de tip intreg mai mari sau egale cu 0 separate printr-un spatiu!");
                        goto outsideLoop;
                    }

                    next[i] = number;
                }

                break;
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
    public static class ArrayHelper
    {
        public static void SortDescending(ref int[] array)
        {
            QuickSort(ref array, 0, array.Length - 1);
            Reverse(ref array);
        }
        public static void SortAscending(ref int[] array)
        {
            QuickSort(ref array, 0, array.Length - 1);
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

            var halfPoint = arr.Length % 2 == 0 ? arr.Length / 2 : (arr.Length + 1) / 2;

            var firstHalf = new int[halfPoint];
            var secondHalf = new int[arr.Length - halfPoint];

            for (var i = 0; i < halfPoint; i++)
            {
                firstHalf[i] = arr[i];
            }

            for (var i = halfPoint; i < arr.Length; i++)
            {
                secondHalf[i - halfPoint] = arr[i];
            }

            ArrayHelper.SortAscending(ref firstHalf);
            ArrayHelper.SortDescending(ref secondHalf);

            for (var i = 0; i < halfPoint; i++)
            {
                arr[i] = firstHalf[i];
            }

            for (var i = halfPoint; i < arr.Length; i++)
            {
                arr[i] = secondHalf[i - halfPoint];
            }

            Console.WriteLine();
            Console.WriteLine("Sirul cu prima jumatate a elementelor ordoante crescator, iar cealalta jumatate ordonate descrescator este:");
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
