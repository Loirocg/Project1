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
            Console.Write("Introdueix el preu del producte: ");
            double preu = double.Parse(Console.ReadLine());

            Console.Write("Indica la forma de pagament: ");
            string pag = Console.ReadLine();

            string[] modes = new string[] {"efectiu", "Efectiu", "targeta", "Targeta"};

            switch(pag)
            {
                case string n when (n == "efectiu" || n == "Efectiu"):
                    Console.WriteLine("Heu escollit pagar en efectiu.");
                    break;

                case string n when (n == "targeta" || n == "Targeta"):
                    Console.Write("Heu escollit pagar amb targeta. Introduiu el numero de compte: ");
                    string compte = Console.ReadLine();
                    if (compte.Length != 10)
                        Console.WriteLine("Compte bancari invalid.");

                    break;

                default:
                    Console.WriteLine("Mode de pagament no disponible.");
                    break;
            }

            Console.ReadKey();
       }   
    }
}
