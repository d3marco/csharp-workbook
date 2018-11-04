using System;

namespace LinkedIn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name");
                string name = TryAnswer();
               
            Console.WriteLine("How old are you?");
            var age = TryAnswer();
    
            

            Console.WriteLine("What month were you born in?");
            var month = TryAnswer();
    

            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("Your birth month is: {0}", month);

        }
        static string TryAnswer()
        {   
            var question = Console.ReadLine();
            if (question == "")
            {
        Console.WriteLine("You didn't type anything, please try again");
            return Console.ReadLine();
            }
            return question;
        }
    }
}