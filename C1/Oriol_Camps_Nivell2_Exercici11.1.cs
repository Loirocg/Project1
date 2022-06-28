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
            while(true)
            {
                Console.Write("Introdueix els valors enters a comparar: ");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());

                if (a < b)
                    Console.WriteLine("El segon valor es major al primer.");

                if (a == b)
                    Console.WriteLine("Els dos valors son iguals.");

                if (a > b)
                    Console.WriteLine("El primer valor es major al segon.");

                Console.ReadKey();
            }
       }   
    }
}
