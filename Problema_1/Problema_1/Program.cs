using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahr, cels,nr;
            Console.Write("Dati gradele (1 pentru fahrenheit si 0 pentru Celsius): ");
            nr = int.Parse(Console.ReadLine());
            switch(nr)
            {
                case 0:
                    Console.WriteLine("Dati gradele in Celsius");
                    cels = int.Parse(Console.ReadLine());
                    fahr = cels * 1.8 + 32;
                    Console.WriteLine($"Gradele transformate din Celsius in Fahrenheit sunt: {fahr}");
                    break;
                case 1:
                    Console.WriteLine("Dati gradele in Fahrenheit");
                    fahr = int.Parse(Console.ReadLine());
                    cels = (fahr - 32) / 1.8;
                    Console.WriteLine($"Gradele transformate din Fahrenheit in Celsius sunt: {cels}");
                    break;

            }
        }
    }
}
