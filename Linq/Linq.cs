using System;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];

            for (int i = 0; i < numbers; i++; )
        }
            {
                numbers[i] = randomGenerator.Next(0, 1000);
            }
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }

        }
    }
}
