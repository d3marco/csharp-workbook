using System;
using System.Collections.Generic;
using System.Linq;

namespace Textgame
{
    class Program
    {
        public static void Main()
        {

            var dict = new Dictionary<string, List<int>>();
             GetUserInput(dict);
        }

       public static void GetUserInput(Dictionary<string , List<int>> grades)
    {

        Console.Write("Enter your students name:");
        string name = Console.ReadLine();
        Console.Write("Enter the student's grades separated by a comma: ");
        var gradeStr = Console.ReadLine();
        var gradeList = gradeStr.Split(',').Select(g=>int.Parse(g)).ToList();
        grades.Add(name,gradeList);

    }
        
    }
}