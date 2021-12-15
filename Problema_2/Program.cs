using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,nr;
            double c,d;
            Console.Write("a= ");
            a=int.Parse(Console.ReadLine());
            Console.Write("b= ");
            b=int.Parse(Console.ReadLine());
            Console.Write("nr= ");
            nr=int.Parse(Console.ReadLine());
            switch(nr)
            {
                case 1:
                    Console.Write("Adunarea numerelor a si b este ");
                    int suma;
                    suma = a + b;
                    Console.Write(suma);
                    Console.WriteLine();
                    break;
                case 2:
                    Console.Write("Diferenta numerelor a si b este ");
                    int diferenta;
                    if (a > b)
                        diferenta = a - b;
                    else
                        diferenta = b - a;
                    Console.Write(diferenta);
                    Console.WriteLine();
                    break;
                case 3:
                    Console.Write("Produsul numerelor a si b este ");
                    int produs;
                    produs = a * b;
                    Console.Write(produs);
                    Console.WriteLine();
                    break;
                case 4:
                    Console.Write("Impartirea numerelor a si b este ");
                    int impartire;
                    if (a > b)
                        impartire = a / b;
                    else
                        impartire = b / a;
                    Console.Write(impartire);
                    Console.WriteLine();
                    break;
                case 5:
                    Console.Write("Dati numarul c: ");
                    c = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Radicalul numarului c este ");
                    double radical;
                    radical = Math.Sqrt(c);
                    Console.Write(radical) ;
                    Console.WriteLine();
                    break;
                case 6:
                    Console.Write("Dati numarul d: ");
                    d = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Modulul numarului d este ");
                    double modul=0;
                    if (d < 0)
                        modul = -d;
                    Console.Write(modul);
                    Console.WriteLine();
                    break;
            }
        }
    }
}
