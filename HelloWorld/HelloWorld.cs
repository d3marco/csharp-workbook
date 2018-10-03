using System;

public class Program
{
    public static void Main()
 {
     string carType = "";
     string model = "";
     int year = 0;

     Console.WriteLine("What is the make of your favorite car:");
     carType = Console.ReadLine();
     Console.WriteLine("What is the model of your favorite car:");
     model = Console.ReadLine();
     Console.WriteLine("Please enter the year:");
     year = Convert.ToInt32(Console.ReadLine());

     Console.WriteLine("You wish you had a {1} {0}.", carType, model, year );

 }

}
