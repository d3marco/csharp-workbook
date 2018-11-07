using System;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter hand 1:");
            string hand1 = Console.ReadLine().ToLower();
            string hand2 = GetComputerHand().ToLower();
            Console.WriteLine("You choose "
            + hand1 + " and the computer choose " + hand2);

            // leave this command at the end so your program does not close automatically
            // Console.ReadLine();

            int outCome = CompareHands(hand1, hand2);
            if (outCome == 0)
            {
                Console.WriteLine("You tied!");
            }
            else if (outCome == 1)
            {
                Console.WriteLine("Hand 1 wins");
            }
            else if (outCome == 2)
            {
                Console.WriteLine("Hand 2 wins");
            } else {
                Console.WriteLine("Please enter a valid hand");
               Console.ReadLine();

            }


        }

        public static int CompareHands(string hand1, string hand2)
        {
            try
            {
                // Your code here
                if (hand1 == hand2)
                {
                    return 0;
                }
                else if (hand1 == "rock" && hand2 == "scissors")
                {
                    return 1;
                }
                else if (hand1 == "rock" && hand2 == "paper")
                {
                    return 2;
                }
                else if (hand1 == "scissors" && hand2 == "rock")
                {
                    return 1;
                }
                else if (hand1 == "scissors" && hand2 == "paper")
                {
                    return 1;
                    // } else if (hand1 ==  hand2)
                    //  {
                    //      Console.WriteLine("Tie");
                    //  } else if (hand1 == "Paper" && hand2 == "Paper")
                    //  {
                    //      Console.WriteLine("Tie");
                }
                else if (hand1 == "paper" && hand2 == "scissors")
                {
                    return 2;
                }
                else if (hand1 == "paper" && hand2 == "rock")
                {
                    return 1;
                }
                else
                {
                    throw new Exception("Please enter a valid hand!");

                }
            }
            catch
            {
                Console.WriteLine("Please enter another choice!");
                 return 3;
            }

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


        public static String GetComputerHand()
        {
            Random Rnd = new Random();
            int randomInt = Rnd.Next(1, 4);

            if (randomInt == 1)
            {
                return "Rock";

            }
            else if (randomInt == 2)
            {
                return "Paper";
            }
            else
            {
                return "Scissors";
            }

        }
    }
}

