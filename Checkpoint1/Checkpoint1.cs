using System;
using System.Threading;

namespace Checkpoint1
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstStep.Counter();
            SecondStep.Ask();
            Thread.Sleep(2000);
            ThirdStep.Factorial();
            Thread.Sleep(2000);
            FourthStep.Chance();
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
                    Console.WriteLine("The number of guesses is " + numOfGuess);
                }
                else if (guess < winNumber)
                {
                    numOfGuess++;
                    Console.WriteLine("Guess is too low, try again. ");
                    Console.WriteLine("The number of guesses is " + numOfGuess);
                }
                else if (guess == winNumber)
                {
                    numOfGuess++;
                    Console.WriteLine("You win! Good job. ");
                    Console.WriteLine("The number of guesses is " + numOfGuess);
                    winner = true;
                }

            }
        }

        class FifthStep
        {
            public static void 
                4342 5801 06546633 0522 936
        }

    }

}
