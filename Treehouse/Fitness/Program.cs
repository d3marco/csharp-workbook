using System;

namespace Treehouse.FitnessFrog
{
    class Program
    {
        static void Main()
        {
            double runningTotal = 0;

            while (true)
            {
                // Prompt user for minutes exercised 
                Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");
                string entry = Console.ReadLine();

                if (entry.ToLower() == "quit")
                {
                    break;
                }
                else
                {
                    try
                    {
                        // Add minutes exercised to total 
                        double minutes = double.Parse(entry);
                        if (minutes <= 0)
                        {
                            Console.WriteLine(minutes + " is not a valid number");
                            continue;
                        }
                        else if (minutes <= 10)
                        {
                            Console.WriteLine("Better than nothing, am I right?");
                        }
                        else if (minutes <= 30)
                        {
                            Console.WriteLine("Way to go hot stuff!");
                        }
                        else if (minutes <= 60)
                        {
                            Console.WriteLine("You must be a ninja warrior in training!");
                        }
                        else
                        {
                            Console.WriteLine("Okay, now you're just showing off!");
                        }

                        runningTotal += minutes;
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("Sorry that wasn't a valid number!");
                        continue;
                    }


                    // Display total minutes exercised to the screen 
                    Console.WriteLine("You've entered " + runningTotal + " minutes.");
                }
                // Repeat until user quits
            }

            Console.WriteLine("Goodbye");
        }
    }
}