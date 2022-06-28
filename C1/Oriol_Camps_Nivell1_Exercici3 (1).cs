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
            Console.Write("Defineix les variables INT X i Y: ");
            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            Console.Write("Defineix les variables DOUBLE N i M: ");
            double N = double.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());

            Console.WriteLine("El valor de X es " + X + "; el valor de Y es " + Y + "; el valor de N es " + N + ";i el valor de M es " + M);

            int sumaxy = X + Y;
            Console.WriteLine("La suma de X+Y = " + sumaxy);

            int restaxy = X - Y;
            Console.WriteLine("La resta de X+Y = " + restaxy);

            int productexy = X * Y;
            Console.WriteLine("El producte de X*Y = " + productexy);

            int divisioxy = X / Y;
            Console.WriteLine("La divisio de X/Y = " + divisioxy);

            int residuxy = X % Y;
            Console.WriteLine("El residu de X%Y = " + residuxy);

            double sumanm = N + M;
            Console.WriteLine("La suma de N+M = " + sumanm);

            double restanm = N - M;
            Console.WriteLine("La resta de N-M = " + restanm);

            double productenm = N * M;
            Console.WriteLine("El producte de N*M = " + productenm);

            double divisionm = N / M;
            Console.WriteLine("La divisio de N/M = " + divisionm);

            double residunm = N % M;
            Console.WriteLine("El residu de N%M = " + residunm);

            double sumaxn = (double)X + N;
            Console.WriteLine("La suma de X+N = " + sumaxn);

            double divisioym = (double)Y / M;
            Console.WriteLine("La divisio de Y/M = " + divisioym);

            double residuym = (double)Y % M;
            Console.WriteLine("El residu de Y%M = " + residuym);

            int doblex = X * 2;
            int dobley = Y * 2;
            double doblen = N * 2;
            double doblem = M * 2;
            Console.WriteLine("El doble de X es " + doblex +"; el doble de Y es "+ dobley +"; el doble de N es "+ doblen +"; el doble de M es "+ doblem);

            double sumat = (double)X + (double)Y + N + M;
            Console.WriteLine("La suma de totes les variables es "+ sumat);

            double productet = (double)X * (double)Y * N * M;
            Console.WriteLine("El producte de totes les variables es " + productet);

            Console.ReadKey();
        }   
    }
}
