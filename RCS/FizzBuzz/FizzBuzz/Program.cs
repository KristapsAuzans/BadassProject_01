using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets play a FizzBuzz Game, please enter any positive NUMBER!");
            string inputAsText = Console.ReadLine();
            int input = int.Parse(inputAsText);

            Console.WriteLine("Thank you, the program will count and give Fizz for any number that can be divided by 3 and Buzz for any number that can be divided by 5. Press 'Enter' to start!");
            Console.ReadLine();

            for (int i = 1; i <= input; i++)

            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }

                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }

    }
}

