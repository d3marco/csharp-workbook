using System;
using System.Linq;
using System.Threading;

namespace Checkpoint1
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstStep.Counter();
            Thread.Sleep(200);

            SecondStep.Ask();
            Thread.Sleep(20);

            ThirdStep.Factorial();
            Thread.Sleep(20);

            FourthStep.Chance();
            Thread.Sleep(20);

            FifthStep.Max();
            Console.ReadLine();

        }
    }

    class FirstStep
    {
        public static void Counter()
        {
            for (int i = 1; i < 100; i++)
            {
                if ( i % 3 == 0)
            {
                    Console.WriteLine(i);
            }
            }
            Console.ReadLine();
        }
    }

    class SecondStep
    {
        public static void Ask()
        {
            int totalInput = 0;

            while (true)
            {
                Console.WriteLine("Enter a number or 'ok' to exit");
                string userInput = Console.ReadLine();
                if (userInput.ToLower() == "ok")
                {
                    break;

                }
                else
                {
                    totalInput += Convert.ToInt32(userInput);
                    Console.WriteLine(totalInput);
                } 
                
            }

        }
    }

    class ThirdStep
    {
        public static void Factorial()
        {
            Console.WriteLine("Please enter your number: ");
            int input = int.Parse(Console.ReadLine());

            int fact = 1;
            for (int i = 1; i <= input; i++)
            {
                fact *= i;
            }
            Console.WriteLine(input + "! =" + fact);
        }
    }

    class FourthStep
    {
        public static void Chance()
        {
            Random rand = new Random();
            int winNumber = rand.Next(1, 11);
            int guess;
            int numOfGuess = 0;
            bool winner = false;
            int maxGuess = 4;


            while (winner == false)
            {

                if (numOfGuess > maxGuess - 1)
                {
                    Console.WriteLine("You have reached the max number of guesses: " + maxGuess);
                    break;
                }

                Console.WriteLine("Enter a number:");
                guess = Convert.ToInt32(Console.ReadLine());


                if (guess > winNumber)
                {
                    numOfGuess++;
                    Console.WriteLine("Guess is too high, try again. ");
                    Console.WriteLine("You have " + numOfGuess + " guesses left");
                }
                else if (guess < winNumber)
                {
                    numOfGuess++;
                    Console.WriteLine("Guess is too low, try again. ");
                    Console.WriteLine("You have " + numOfGuess + " guesses left");
                }
                else if (guess == winNumber)
                {
                    numOfGuess++;
                    Console.WriteLine("You win! Good job. ");
                    Console.WriteLine("You have " + numOfGuess + " guesses left");
                    winner = true;
                }

            }
        }

    }
    class FifthStep
    {

        //Write a program and ask the user to enter a series of numbers separated by comma.
        //    Find the maximum of the numbers and display it on the console.
        //    For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
        public static void Max()
        {
            Console.WriteLine("Enter a series of number seprated by commas:");
            string userNumb = Console.ReadLine();

            string[] split = userNumb.Split(",");
            Console.WriteLine(split.Max());

        }

    }

}
