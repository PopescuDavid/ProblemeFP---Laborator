using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problema_62
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
        public static double[] NextDoubleArray(int length)
        {
            var next = new double[length];

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

                    if (!double.TryParse(str, out var number))
                    {
                        Console.WriteLine(
                            "Te rugam sa te asiguri ca sirul contine valori de tip dublu separate printr-un spatiu!");
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
    }
        class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti valoarea lui n:");
            var n = CRead.NextPositiveInt();

            while (n > 100)
            {
                Console.WriteLine("Valoarea lui n trebuie sa fie mai mica sau egala cu 100!");
                n = CRead.NextPositiveInt();
            }

            Console.WriteLine("Introduceti elementele sirului separate printr-un spatiu:");
            var arr = CRead.NextDoubleArray(n);

            if (arr.Length == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Sirul nou este:");
                Console.WriteLine(string.Join(", ", arr));
                return;
            }

            for (var i = 0; i < arr.Length - 1; i++)
            {
                ArrayHelper.Add(ref arr, i + 1, (arr[i] + arr[i + 1]) / 2);
                i++;
            }

            Console.WriteLine();
            Console.WriteLine("Sirul nou este:");
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
