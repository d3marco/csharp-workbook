using System;
using System.Threading;

namespace TextGame
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Welcome to the cavern of secrets!");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Thread.Sleep(1000);
            Console.WriteLine("You enter a dark cavern out of curiosity. It is dark and you can only make out a small stick on the floor.");
            Console.WriteLine("Do you take it? [y/n]: ");
            string ch1 = Console.ReadLine();
            string ch2 = Console.ReadLine();
            string ch3 = Console.ReadLine();

            int stick = 0;
            if (ch1 == "y")
            {
                Console.WriteLine("You have taken the stick!");
                Thread.Sleep(2000);
                stick = 1;
            }
            else
            {
                Console.WriteLine("You did not take the stick");
                stick = 0;
                Console.WriteLine("As you proceed further into the cave, you see a small glowing object");

            }
            if (ch2 == "y")
            {
                Console.WriteLine("You approach the object...");
                Thread.Sleep(2000);
                Console.WriteLine("As you draw closer, you begin to make out the object as an eye!");
                Thread.Sleep(2000);
                Console.WriteLine("The eye belongs to a giant spider!");
                Console.WriteLine("Do you try to fight it? [Y/N]");
            }
            if (ch3 == "y")
            {
                if (stick == 1)
                    Console.WriteLine("You only have a stick to fight with!");
                Console.WriteLine("You quickly jab the spider in it's eye and gain an advantage");
                Thread.Sleep(2000);
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("                  Fighting...                   ");
                Console.WriteLine("   YOU MUST HIT ABOVE A 5 TO KILL THE SPIDER    ");
                Console.WriteLine("IF THE SPIDER HITS HIGHER THAN YOU, YOU WILL DIE");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Thread.Sleep(2000);
                // Random randomNub = new Random();
                // int fdmg1 = Random.Next(3, 11);
                // int edmg1 = Random.Next(1, 6); 
                //the random number gen will not display properly- im getting an error message
                Console.WriteLine("you hit a");
                Console.WriteLine("the spider hits a");
                Thread.Sleep(2000);
            }
        

        }
    }
}
