using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteMathProject1
{
    class Ex3 : Ex
    {
        public static void Permutations()
        {
            Console.WriteLine("You want to see all possible permutations for ? items:");
            List<int> numbers = GenerateNumbers(Convert.ToInt32(IfNumber("y")));

            foreach (List<int> value in GeneratePermutations(numbers))
            {
                for (int i = 0; i < value.Count; i++)
                {
                    Console.Write(value[i]+" ");
                }
                Console.Write(";");
            }
        }

        public static void CheckPermutation()
        {
            List<int> inputList=new List<int>();
            Console.WriteLine("Enter integer numbers to check if it is a permutation");
            Console.WriteLine("Separate it with SPACE BAR");

            string permutationStr = Console.ReadLine();
            string[] numbersStr = permutationStr.Split(' ');
            for (int i = 0; i < numbersStr.Length; i++)
            {
                int num;
                if (int.TryParse(numbersStr[i], out num))
                {
                    inputList.Add(Convert.ToInt32(numbersStr[i]));
                }
                else
                {
                    Console.WriteLine("It's not correctly entered permutation");
                    break;
                }
            }
            if (IsPermutation(inputList))
            {
                Console.WriteLine("This is a permutation");
            }
            else
            {
                Console.WriteLine("This is NOT a permutation");
            }
        }
        /**********************************************/

        private static List<int> GenerateNumbers(int amount)
        {
            List<int> numbers = new List<int>();
            for (int i = 1; i <= amount; i++)
            {
                numbers.Add(i);
            }
            return numbers;
        }

        private static bool IsPermutation(List<int> inputList)
        {
            List<int> znane = new List<int>();
            for (int i = 0; i < inputList.Count; i++)
            {
                if (znane.Contains(inputList[i]))
                    return false;
                znane.Add(inputList[i]);
            }
            return true;
        }

        private static IEnumerable<List<int>> GeneratePermutations(List<int> numbers)
        {
            if (numbers.Count == 2)
            {
                yield return new List<int>(numbers);
                yield return new List<int> { numbers[1], numbers[0] };
            }
            else
            {
                foreach (var number in numbers)
                {
                    var newList = new List<int>(numbers);
                    newList.Remove(number);
                    foreach (List<int> list in GeneratePermutations(newList))
                    {
                        list.Insert(0, number);
                        yield return list;
                    }
                }
            }
        }
    }
}
