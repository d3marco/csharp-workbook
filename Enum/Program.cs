using System;

namespace Enum
{
    enum PrimaryColors
    {
        RED, BLUE, YELLOW
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Enum!");
            string primaryCombined = combinePrimaryColors(PrimaryColors.RED, PrimaryColors.YELLOW);
            Console.WriteLine("Red + Yellow = "+primaryCombined);
        }
        public static String combinePrimaryColors(PrimaryColors color1, PrimaryColors color2)
        {
            
        }
    }
}
