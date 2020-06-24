using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a List called "numbers" - DONE
            var numbers = new List<int>();

            //Create a variable of type int and initialize the variable with a value of 0 - DONE
            int num = 0;


            // Create a do-while loop

            do
            {
                // Increment your variable by 1 -DONE
                num++;
                // Then add your variable to "numbers"- DONE
            } while (num < 100);
            // While your variable is less than 100- DONE



            // Create a while loop
            // While your variable is less than 200- DONE
            while (num <200)
            {
                // Increment your variable by 1- DONE
                num++;
                numbers.Add(num);
                // Then add your variable to "numbers"- DONE
            }

            Console.WriteLine("Increase:");

            // Create a foreach loop
            foreach (var init in numbers)
                // Write your variable to the console
            {
                Console.WriteLine($"{init}"); ;
            }
            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            // Create a for loop)
            for (int i = 199; i <= numbers.Count && i >= 0; i--)
            // in your initializer set the value of i to 199- DONE
            // in your conditional, as long as i is less than or equal to the length of "numbers" -DONE
            // and as long as i is greater than or equal to 0 - DONE
            // Decrement i by 1 - DONE
            {
                Console.WriteLine($"{numbers[i]}");

                // Write to the console "numbers" at index i -ONE
            }
        }
    }
}
