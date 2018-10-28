using System;
using System.Threading;

namespace Checkpoint1
{
    class Program
    {
        static void Main()
        {
            int i;
            for (i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);

                }
            }
            Number();
            Thread.Sleep(2000);
            Factorial();
            Thread.Sleep(2000);




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

            while(true)
            {
                Console.WriteLine("Pick a random number between 1-10");
                int num = int.Parse(Console.ReadLine());
                Random userNum = new Random.Next(1,11);


                if (userNum == num)
                {

                }
            }

        }




    }

}