﻿using System;
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
            Console.Write("Llista de valors parells i multiples de 3 de entre 1-100: ");

            int i = 1;
            int residu;
            while(i<=100)
            {
                residu = i % 2;

                if (residu == 0)
                    Console.WriteLine(i);

                i++;
            }
            

            Console.ReadKey();
       }   
    }
}
