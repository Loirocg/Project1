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
            Console.Write("Quin es el teu nom? ");
            string nom = Console.ReadLine();
            Console.Write("Quin es el nom de la ciutat? ");
            string ciutat = Console.ReadLine();
            Console.WriteLine("Hola, " + nom + ". Benvingut a " + ciutat);
            Console.ReadKey();
        }   
    }
}
