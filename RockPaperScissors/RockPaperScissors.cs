using System;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter hand 1:");
            string hand1 = Console.ReadLine().ToLower();
            Console.WriteLine("Enter hand 2:");
            string hand2 = Console.ReadLine().ToLower();
            Console.WriteLine(CompareHands(hand1, hand2));

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
            
        
        }
        
        public static string CompareHands(string hand1, string hand2)
        {
            // Your code here
            if (hand1 == "rock" && hand2 == "rock")
            {
                Console.WriteLine("Tie");
            } else if (hand1 == "rock" && hand2 == "scissors")
            {
                Console.WriteLine("hand1 wins!");
            } else if (hand1 == "rock" && hand2 == "paper")
            {
                Console.WriteLine("hand2 wins!");
            } else if (hand1 == "scissors" && hand2 == "rock")
            {
                Console.WriteLine("hand2 wins");
            } else if (hand1 == "scissors" && hand2 == "paper")
            {
                Console.WriteLine("hand1 wins");
            } else if (hand1 == "scissors" && hand2 == "scissors")
             {
                 Console.WriteLine("Tie");
             } else if (hand1 == "paper" && hand2 == "paper")
             {
                 Console.WriteLine("Tie");
             } else if (hand1 == "paper" && hand2 == "scissors")
             {
                 Console.WriteLine("hand2 wins");
             } else if (hand1 == "paper" && hand2 == "rock")
             {
                 Console.WriteLine("hand1 wins");
             } else
             {
                 Console.WriteLine("try again");
             }
        
            
            return hand1 + ' ' + hand2;
        }
        // public static bool test()
        // {
        //     return 0;

        //     CompareHands("Paper", "Paper") == 0 &&
        //     CompareHands("Paper", "Rock") == 1 &&
        //     CompareHands("Paper", "Scissors") == 2 &&
        //     CompareHands("Rock", "Paper") == 2 &&
        //     CompareHands("Rock", "Rock") == 0 &&
        //     CompareHands("Rock", "Scissors") == 1 &&
        //     CompareHands("Scissors", "Paper") == 1 &&
        //     CompareHands("Scissors", "Scissors") == 0 &&
        //     CompareHands("Scissors", "Rock") == 2;
            
        // }
    }
}
