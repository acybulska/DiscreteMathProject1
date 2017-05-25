using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteMathProject1
{
    class Ex2 : Ex
    {
        public static void PrimeNumbers()
        {
            Console.WriteLine("Prime numbers\n");
            Console.WriteLine("(shall be integer)\n");
            int number = Convert.ToInt32(IfNumber("y"));
           
            Console.WriteLine("Primes: \n");
            for (int i = 0; i < number; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write(i + "; ");
                }
            }
            Console.WriteLine("\n");
        }
    }
}
