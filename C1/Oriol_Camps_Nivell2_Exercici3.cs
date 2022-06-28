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
            string nom = "a";
            string edat = "a";
            bool correcte = false;
            char[] num = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0'};
            char[] lletra = new char[] {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
            
            while (correcte == false)
            {
                Console.Write("Quin es el teu nom? ");
                nom = Console.ReadLine();

                for(int i = 1; i <= nom.Length; i++)
                {
                    correcte = true;
                    for(int k = 1; k <= num.Length; k++)
                    {
                        if (nom[i - 1] == num[k - 1])
                        {
                            Console.WriteLine("Nom invalid. Prova-ho de nou.");
                            k = 100;
                            i = 100;
                            correcte = false;
                        }
                    }
                }
            }

            correcte = false;

            while (correcte == false)
            {
                Console.Write("Quina es la teva edat? ");
                edat = Console.ReadLine();

                for (int i = 1; i <= edat.Length; i++)
                {
                    correcte = true;
                    for (int k = 1; k <= lletra.Length; k++)
                    {
                        if (edat[i - 1] == lletra[k - 1])
                        {
                            Console.WriteLine("Edat invalida. Prova-ho de nou.");
                            k = 100;
                            i = 100;
                            correcte = false;
                        }
                    }
                }

                //Console.ReadKey();
                if (correcte == true)
                {
                    if (int.Parse(edat) < 0 || int.Parse(edat) >= 120)
                    {
                        Console.WriteLine("Edat invalida. Prova-ho de nou.");
                        correcte = false;
                    }
                }
                    
            }

            Console.WriteLine("Et dius " + nom + " i tens " + edat + " anys.");
            Console.ReadKey();
        }   
    }
}
