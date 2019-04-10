using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            //Let the user input a number to determine even or odd

            Console.WriteLine("Let's determine if your number is even or odd. Please enter a whole number: ");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            //Determine the remainder to see if it = 0 (an even #) or has one (odd #)
            int remainder = number % 2;

            if (remainder == 0)
            {
                Console.WriteLine("Your number of " +number +" is even");
            }

            else
            {
                Console.WriteLine("Your number of " + number + " is odd");
            }

            Console.ReadKey();

        }
    }
}
