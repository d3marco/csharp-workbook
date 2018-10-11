using System;

namespace Week2_2_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int grade = 0;
            Console.WriteLine("Please enter a number from 0 - 100:");
            String input = Console.ReadLine();
            grade = Convert.ToInt32(input);

            if (grade >= 90){
                Console.WriteLine("You made an A!");
            } else if (grade >= 80){
                Console.WriteLine("You made a B!");
            } else if (grade >= 70){
                Console.WriteLine("You made a C!");
            } else {
                Console.WriteLine("You Failed!!!");
            }

            Console.Write("End of Program");
        }
    }
}
