using System;

namespace Week1_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int input1 = 0;
            int input2 = 0;

            Console.WriteLine("Give me a number between 0 and 100:");
            input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give me another number between 0 and 100:");
            input2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(input1 + input2);

            int yardLength = 0;
            int inchLength = 0;
            Console.WriteLine("Give me a number of yards?");
            yardLength = Convert.ToInt32(Console.ReadLine());
            inchLength = (yardLength * 36);

            Console.WriteLine("You have {0} inches!", inchLength);

            bool people = true;
            bool f = false;
            decimal numb = 0.0M;


            string firstName = "DeMarco";
            string lastName = "Spears";
            int age = 27;
            string job = "Client Support Agent";
            string favoriteBand = "Beetles";
            string favoriteSportsTeam = "Golden State Warriors";


            Console.WriteLine("Give me a decimal number?");
            numb = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(numb * numb);
            Console.WriteLine("I love sports my favorite team is the {0}", favoriteSportsTeam);
            Console.WriteLine("My birthday is on the forth of July, I'm {0} years old!", age);
            Console.WriteLine("My favorite band of all time is the {0}!", favoriteBand);
            Console.WriteLine("I work at Dell as a {0}!", job);

        }
    }

}
