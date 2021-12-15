using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problema_Sortare_4
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
        public static uint[] NextUnsignedIntArray(int length)
        {
            var next = new uint[length];

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

                    if (!uint.TryParse(str, out var number))
                    {
                        Console.WriteLine(
                            "Te rugam sa te asiguri ca sirul contine valori de tip intreg fara semn separate printr-un spatiu!");
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
        public static bool IsPalindrome<T>(T[] array)
        {
            var i = 0;
            var j = array.Length - 1;
            while (i <= j)
            {
                if (!array[i].Equals(array[j]))
                {
                    return false;
                }

                i++;
                j--;
            }

            return true;
        }
        public static T[] GetFirstPalindromePermutation<T>(T[] array, int size)
        {
            if (size == 1)
            {
                if (IsPalindrome(array))
                {
                    return array;
                }
            }

            for (var i = 0; i < size; i++)
            {
                var permutation = GetFirstPalindromePermutation(array, size - 1);
                if (permutation != null)
                {
                    return permutation;
                }

                if (size % 2 == 1)
                {
                    (array[0], array[size - 1]) = (array[size - 1], array[0]);
                }
                else
                {
                    (array[i], array[size - 1]) = (array[size - 1], array[i]);
                }
            }

            return null;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti valoarea lui n:");
            var n = CRead.NextPositiveInt();

            Console.WriteLine("Introduceti elementele sirului separate printr-un spatiu:");
            var arr = CRead.NextUnsignedIntArray(n);

            if (ArrayHelper.IsPalindrome(arr))
            {
                Console.WriteLine();
                Console.WriteLine("Sirul dat este palindrom.");
                return;
            }

            Console.WriteLine();
            Console.WriteLine(ArrayHelper.GetFirstPalindromePermutation(arr, arr.Length) != null
                ? "Sirul dat poate fi un palindrom"
                : "Sirul dat nu poate fi palindrom");
        }
    }
}
