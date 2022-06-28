using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdueix el valor del radi:");
            double radi = double.Parse(Console.ReadLine());

            double area = Math.Pow(radi, 2) *Math.PI;
            Console.WriteLine("L'area del cercle de radi " + radi + " es " + area);
            Console.ReadKey();
       }   
    }
}
