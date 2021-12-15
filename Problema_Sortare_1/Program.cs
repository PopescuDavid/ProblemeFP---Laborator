using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problema_Sortare_1
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
        public static void SortAscending(ref int[] array)
        {
            QuickSort(ref array, 0, array.Length - 1);
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

            if (n == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Sirul are mai putin de doua elemente.");
                return;
            }

            var distinctElements = arr.Distinct().ToArray();
            if (distinctElements.Length <= 1)
            {
                Console.WriteLine();
                Console.WriteLine("Sirul dat nu contine cel putin 2 delemente distincte. Nu se poate calcula nici o suma.");
                return;
            }

            var sums = new List<int>();

            for (var i = 0; i < distinctElements.Length; i++)
            {
                for (var j = i + 1; j < distinctElements.Length; j++)
                {
                    if (distinctElements[i] == distinctElements[j])
                    {
                        continue;
                    }

                    sums.Add(distinctElements[i] + distinctElements[j]);
                }
            }

            var newArr = sums.Distinct().ToArray();
            ArrayHelper.SortAscending(ref newArr);

            Console.WriteLine();
            Console.WriteLine("Valorile distincte in ordine crescatoare care se pot obtine ca suma de doua elemente distincte din sir sunt:");
            Console.WriteLine(string.Join(", ", newArr));
        }
    }
}
