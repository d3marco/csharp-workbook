using System;

namespace Passcode
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string code = "";

            
            while (code != "secert")
            {
                if(code != "secert")
                {
                Console.WriteLine("What is the pass code?");
                code = Console.ReadLine();   
                 
                }
            }
            Console.WriteLine("Acess granted!");
        }
    }
}
