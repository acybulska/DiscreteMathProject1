using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteMathProject1
{
    class Ex1 : Ex
    {
        public static void CeilingFloorFraction()
        {
            Console.WriteLine("Floor, ceiling, fraction\n");

            IfInteger(SplitNumber(IfNumber("n")));
        }

        public static void Modulo()
        {
            Console.WriteLine("Modulo\n");

            Console.WriteLine("Divident (shall be integer)");
            int nr = Convert.ToInt32(IfNumber("y"));
            Console.WriteLine("Division (shall be integer)");
            int div = Convert.ToInt32(IfNumber("y"));

            while (nr >= div)
            {
                nr = nr - div;
            }
            Console.WriteLine("Modulo: " + nr);
        }

        /**********************************************/

        private static string[] SplitNumber(string number)
        {
            string[] values;

            if (number.Contains("."))
            {
                values = number.Split('.');
                return values;
            }

            values = number.Split(',');
            return values;
        }

        private static void IfInteger(string[] values)
        {
            int i = values.Length;
            if (i != 2)
            {
                Console.WriteLine("Ceiling: " + values[0]);
                Console.WriteLine("Floor: " + values[0]);
                Console.WriteLine("No fraction");
            }
            else
            {
                IfNegative(values);
            }
        }

        private static void IfNegative(string[] values)
        {
            if (values[0].StartsWith("-"))
            {
                int floor = Convert.ToInt32(values[0]) - 1;
                Console.WriteLine("Ceiling: " + values[0]);
                Console.WriteLine("Floor: " + floor);
                Console.WriteLine("Fraction: " + values[1]);
            }
            else
            {
                int ceiling = Convert.ToInt32(values[0]) + 1;
                Console.WriteLine("Floor: " + values[0]);
                Console.WriteLine("Ceiling: " + ceiling);
                Console.WriteLine("Fraction: " + values[1] + "\n");
            }
        }
    }
}
