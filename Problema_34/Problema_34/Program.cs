using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problema_34
{
    public static class CRead
    {
        private static readonly Regex Separator = new Regex(" +");
        public static double NextUnsignedDouble()
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

                if (!parsed || next < 0)
                {
                    Console.WriteLine("Te rugam introdu o valoare de tip dublu mai mare sau egala cu 0!");
                }
            }

            return next;
        }
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
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Doriti sa transformati din radiani in grade (1) sau din grade in radiani (2)?");
            var input = CRead.NextPositiveInt();

            while (input > 2)
            {
                Console.WriteLine("Optiuni: 1 - Conversie din radiani in grade sau 2 - Conversie din grade in radiani");
                input = CRead.NextPositiveInt();
            }

            switch (input)
            {
                case 1:
                    const double radian = 57.2958;
                    Console.WriteLine("Radiani:");
                    var radians = CRead.NextUnsignedDouble();

                    Console.WriteLine();
                    Console.WriteLine($"{radians} radiani = {radians * radian} grade");
                    break;
                case 2:
                    const double degree = 0.017453;
                    Console.WriteLine("Grade:");
                    var degrees = CRead.NextUnsignedDouble();

                    Console.WriteLine();
                    Console.WriteLine($"{degrees} grade = {degrees * degree} radiani");
                    break;
            }
        }
    }
}
