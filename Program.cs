using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteMathProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Discrete Mathematics - Project, list 1\n\n");

            int choice = 0;
            while (choice != -1)
            {
                Menu();

                Console.WriteLine("Do you want to finish? Y/N");
                string finish = Console.ReadLine();
                if (finish == "Y" || finish == "y")
                {
                    choice = -1;
                }
                else
                {
                    choice = 0;
                }
            }
        }

        static void Menu()
        {
            string ex = "-1";
            Console.WriteLine("MENU");
            Console.WriteLine("Ex.1 - 1");
            Console.WriteLine("Ex.2 - 2");
            Console.WriteLine("Ex.3 - 3");
            ex = Console.ReadLine();
            if (ex == "1")
            {
                Console.WriteLine("Ex. 1\n\n");
                Ex1.CeilingFloorFraction();
                Ex1.Modulo();
            }
            else if (ex == "2")
            {
                Console.WriteLine("Ex. 2\n\n");
                Ex2.PrimeNumbers();
            }
            else if (ex == "3")
            {
                Console.WriteLine("Ex. 3\n\n");
                Ex3.Permutations();
                Ex3.CheckPermutation();
            }
        }
    }
}
