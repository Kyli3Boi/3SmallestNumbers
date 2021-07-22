using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3SmallestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This will display 3 smallest numbers in list provided");
            Console.WriteLine();
            Console.WriteLine("Type 5 number seperated by a ,");
            Console.WriteLine("EG. 1,2,3,4,5");
            Console.WriteLine();
            Console.Write("Your numbers: ");

            string userInput;
            string[] splitNumbers = new string [5];
            int count;
            int[] numbers = new int[5];

            while (true)
            {
                userInput = Console.ReadLine();
                
                splitNumbers = userInput.Split(',');
                count = splitNumbers.Count();
                
                if (!string.IsNullOrEmpty(userInput) && count == 5)
                {
                    splitNumbers = userInput.Split(',');
                    
                    for (int i = 0; i < 5; i++)
                    {
                        numbers[i] = Convert.ToInt32(splitNumbers[i]);
                    }

                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid list. Please try again");
                    Console.Write("Your numbers: ");
                    continue;
                }
            }

            Array.Sort(numbers);
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Lowest number ({0}): {1}", i + 1, numbers[i]);
            }

            Console.WriteLine();
        }
    }
}
