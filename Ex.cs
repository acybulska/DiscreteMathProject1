using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteMathProject1
{
    public class Ex
    {
        protected static string IfNumber(string ifInt)
        {
            int choice = -1;
            while (choice != 0)
            {
                Console.WriteLine("Enter a number: ");
                string number = Console.ReadLine();
                if (ifInt == "y")
                {
                    int num;
                    if (int.TryParse(number, out num))
                    {
                        return number;
                    }
                }
                else if (ifInt == "n")
                {
                    double num;
                    if (double.TryParse(number, out num))
                    {
                        return number;
                    }
                }
                Console.WriteLine("It's not a number!");
                Console.WriteLine("Do you want to try again? Y/N");
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
            return null;
        }
    }
}
