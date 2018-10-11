using System;

namespace Week2_2_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            userInput = Console.ReadLine(Convert.ToInt32());
            Console.WriteLine("Please provide a number 0 - 100:");
            if(userInput => 90)
            {
                Console.WriteLine("You got an A!");
            }
            else
            {
                Console.WriteLine("sorry buddy!")
            }
        }
    }
}
