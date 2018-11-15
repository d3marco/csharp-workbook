using System;

namespace LinkedIn
{
    class Program
    {
        static void Main(string[] args)
        {
           var SurveyData = new SurveyData();
            Console.WriteLine("What is your name");
                SurveyData.Name = TryAnswer();
               
            Console.WriteLine("How old are you?");
            SurveyData.Age = int.Parse(TryAnswer());
    
            

            Console.WriteLine("What month were you born in?");
            SurveyData.Month = TryAnswer().ToLower();
    

            Console.WriteLine("Your name is: {0}", SurveyData.Name);
            Console.WriteLine("Your age is: {0}", SurveyData.Age);
            Console.WriteLine("Your birth month is: {0}", SurveyData.Month);

            if (SurveyData.Month == "march")
            {
                Console.WriteLine("you are an Aries!");

            } else if (SurveyData.Month == "july")
            {
                Console.WriteLine("you are a Cancer!");
            } else if (SurveyData.Month == "may")
            {
                Console.WriteLine("you are a Gemini!");
            } else{
                Console.WriteLine("not sure you zodiac sign!");
            }

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
    class SurveyData
    {
        public string Name;
        public string Month;
        public int Age; 
    }
}