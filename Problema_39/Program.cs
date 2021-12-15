using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problema_39
{
    public static class CRead
    {
        private static readonly Regex Separator = new Regex(" +");
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
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti orele pentru primul moment temporar:");
            var hoursFirst = CRead.NextNaturalNumber();

            Console.WriteLine("Introduceti minutele pentru primul moment temporar:");
            var minutesFirst = CRead.NextNaturalNumber();

            Console.WriteLine("Introduceti secundele pentru primul moment temporar:");
            var secondsFirst = CRead.NextNaturalNumber();


            Console.WriteLine("Introduceti orele pentru cel de-al doilea moment temporar:");
            var hoursSecond = CRead.NextNaturalNumber();

            Console.WriteLine("Introduceti minutele pentru cel de-al doile moment temporar:");
            var minutesSecond = CRead.NextNaturalNumber();

            Console.WriteLine("Introduceti secundele pentru cel de-al doilea moment temporar:");
            var secondsSecond = CRead.NextNaturalNumber();

            var difference = new TimeSpan(hoursFirst, minutesFirst, secondsFirst) - new TimeSpan(hoursSecond, minutesSecond, secondsSecond);

            Console.WriteLine();
            Console.WriteLine("Diferenta dintre cele doua momente de timp este de: {0} {1}, {2} {3} si {4} {5}.",
                (int)Math.Floor(difference.TotalHours),
                (int)Math.Floor(difference.TotalHours) == 1 ? "ora" : "ore",
                difference.Minutes,
                difference.Minutes == 1 ? "minut" : "minute",
                difference.Seconds,
                difference.Seconds == 1 ? "secunda" : "secunde"
            );
        }
    }
}
