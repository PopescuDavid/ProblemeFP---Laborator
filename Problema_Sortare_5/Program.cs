using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problema_Sortare_5
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
    }
    public static class ArrayHelper
    {
        public static void Add<T>(ref T[] array, int pos, T element)
        {
            if (pos > array.Length)
            {
                pos = array.Length;
            }

            Array.Resize(ref array, array.Length + 1);

            for (var i = array.Length - 1; i > pos; i--)
            {
                array[i] = array[i - 1];
            }

            array[pos] = element;
        }
        public static void Remove<T>(ref T[] array, int pos)
        {
            if (pos < 0 || pos >= array.Length)
            {
                return;
            }

            for (var i = pos; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            Array.Resize(ref array, array.Length - 1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti valoarea lui n:");
            var n = CRead.NextPositiveInt();

            Console.WriteLine("Introduceti elementele sirului separate printr-un spatiu:");
            var arr = CRead.NextNaturalNumbersArray(n);
            ArrayHelper.Add(ref arr, 0, 0);

            var sorted = arr
                .Select((value, index) => new KeyValuePair<int, int>(value, index))
                .OrderBy(pair => pair.Key)
                .Select(pair => pair.Value).ToArray();

            ArrayHelper.Remove(ref sorted, 0);

            Console.WriteLine();
            Console.WriteLine("Numerele de ordine ale copiilor in ordinea crescatoare a inaltimii lor sunt:");
            Console.WriteLine(string.Join(", ", sorted));
        }
    }
}
