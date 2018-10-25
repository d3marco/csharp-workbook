using System;
using System.Threading;
using System.Collections.Generic;

namespace Week4practice2
{
    class Program
    {
        static void Main()
        {
            list<string> personName = new list<string>("John", "Mike", "Sam");

            personName.Add("John");
            personName.Add("Mike");
            personName.Add("Sam");

            foreach (String name in personName)
            {
                Console.WriteLine(personName);
            }
            names.RemoveAt(2);

            foreach (String name in personName)
            {
                Console.WriteLine(personName);
            }

        }
    }
}

//peek();
//pop();
//push(); push to stack
//count();
//Deepth first before breath first

//Stack<String> var*stackname = new Stack<String>();
var.Push("John");
var.Push("Sam");
var.Push("Paul");

while(name.Count > 0)
{
    String currentName = names.Pop();
    Console.WriteLine("Processing" +currentName);
}
