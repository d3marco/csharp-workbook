using System;

namespace Quiz3
{
    class Program
    {
        public static void Main(string[] args)
        {
            int firstNumb;
            int sencondNumb;
            Console.WriteLine("Please provide a number:");
           firstNumb = Convert.ToInt32(Console.ReadLine());
            sencondNumb = Convert.ToInt32(Console.ReadLine());
        
        int sum = Addition(firstNumb + sencondNumb);
        }
        public static int Addition(int firstNumb , int sencondNumb)
        {
            
            return firstNumb + sencondNumb;
        
        }

    }

}
