using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problema_41
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
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cate zile ii ia un muncitor sa termine lucrarea:");
            var n = CRead.NextPositiveInt();

            Console.WriteLine("Cati muncitori vor fi in echipa:");
            var m = CRead.NextPositiveInt();

            Console.WriteLine();
            Console.WriteLine($"Unei echipe de {m} muncitor(i) le va lua {(double)n / m} zile sa termine lucrarea.");
        }
    }
}
