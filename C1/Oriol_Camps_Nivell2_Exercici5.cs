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
            Console.Write("Escriu el dia de la setmana: ");
            string dia = Console.ReadLine();

            switch(dia)
            {
                case "Dilluns":
                case "dilluns":
                case "Dimarts":
                case "dimarts":
                case "Dimecres":
                case "dimecres":
                case "Dijous":
                case "dijous":
                case "Divendres":
                case "divendres":
                    Console.WriteLine("Aquest dia de la setmana no es del cap de setmana.");
                    break;
                case "Dissabte":
                case "dissabte":
                case "Diumenge":
                case "diumenge":
                    Console.WriteLine("Aquest dia de la setmana es del cap de setmana.");
                    break;
                default:
                        Console.WriteLine("Aquest dia de la setmana no existeix.");
                        break;
                }
            Console.ReadKey();
       }   
    }
}
