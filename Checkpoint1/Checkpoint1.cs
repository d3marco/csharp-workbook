using System;
using System.Threading;

namespace Checkpoint1
{
    class Program
    {
        static void Main()
        {
            int i;
            //declared the var i to be used in my for loop
            for (i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);

                }
            }
            Number();
            Thread.Sleep(2000);
            //wanted the next methods to display on the console using a delay
            Factorial();
            Thread.Sleep(2000);
            PickNum();
            Thread.Sleep(2000);
            Max();




        }
        static void Number()
        {
            int sum = 0;
            while (true)
            {
                Console.Write("Enter a number:  or ok to exit : ");
                String input = Console.ReadLine();
                if (input == "ok" || input.ToLower() == "ok") break;
                if (string.IsNullOrWhiteSpace(input))
                //i found the class IsNullorWhiteSpace online and thought I should try it out
                    continue;
                sum += Convert.ToInt32(input);
                Console.WriteLine(sum);
            }
            Console.WriteLine(sum);
        }

        static void Factorial()
        {
            Console.WriteLine("Please enter your number: ");
            int input = int.Parse(Console.ReadLine());

            int fact = 1;
            for (int i = 1; i <= input; i++)
            {
                fact *= i;
            }

            Console.WriteLine("The Factorial is " + fact);
        }

        static void PickNum()
        {
            int i;

            for (i = 1; i <=4; i++)
            {
                Console.WriteLine("Pick a random number between 1-10");
                int number = int.Parse(Console.ReadLine());
                Random rnd = new Random();
                int userNum = rnd.Next(1,11);

                if (userNum == number)
                {
                Console.WriteLine("You Won");
                break;

                } else {
                    Console.WriteLine("You Lost");
                    Console.WriteLine();
                }
                
            }
            

        }
        static void Max()
{

            Console.Write("Please enter a series of numbers separated by a comma:  ");
            string userInput = Console.ReadLine();

            string[] numbers = userInput.Split(',');
            int max = 0;
            int sum = 0;

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                if (Convert.ToInt32(numbers[i]) > max)
                {
                    max = Convert.ToInt32(numbers[i]);
                    // sum = Convert.ToInt32( sum + numbers[i]);
                }
            }
            Console.WriteLine(max + " is the max ");
            // Console.WriteLine(sum + " is the total of all the numbers ");
            Console.ReadLine();
        }



    }

}