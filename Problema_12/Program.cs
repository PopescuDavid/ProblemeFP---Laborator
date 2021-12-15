using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fahrenheit | Celsius");
            for (var i = 0; i <= 300; i++)
            {
                Console.WriteLine("{0} | {1:f4}", i, 5.0 / 9.0 * (i - 32.0));
            }
        }
           
    }
}
