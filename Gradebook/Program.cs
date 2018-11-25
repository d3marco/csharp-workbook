using System;
using System.Linq;
using System.Collections.Generic;
namespace Grades.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> grades = getStudent();
            foreach(var key in grades.Keys)
            {
                Console.WriteLine("Students Name: " + key);
                Console.WriteLine("The Average grade is " + grades [key].Average());
                Console.WriteLine("The Minimum grade is " + grades [key].Min());
                Console.WriteLine("The Max grade is " + grades [key].Max());
            }
            
        }
        public static Dictionary<string, List<int>> getStudent()
        {
            Dictionary<string, List<int>> grades = new Dictionary<string, List<int>>();
            //Prompt User to Add names of the Student they want to add.
            Console.WriteLine("What is the Students name? ");
            string name = Console.ReadLine();
            grades.Add(name, getStudentGrade());
            Console.WriteLine("Do you want to add another Student?");
            string keepAdding = Console.ReadLine().ToLower();
             while(keepAdding != "no")
            {
                Console.WriteLine("What is the students name?");
                string newAnswer = Console.ReadLine();
                grades.Add(newAnswer, getStudentGrade());
                Console.WriteLine("Do you want to add another Student?");
                keepAdding = Console.ReadLine();
            }
            return grades;
        }
        public static List<int> getStudentGrade()
        {
            
            List<int> gradebook = new List<int>();
             Console.WriteLine("What is the Students grade?");
            int grade = Convert.ToInt32(Console.ReadLine());
            
            gradebook.Add(grade);
             Console.WriteLine("Do you want to add another grade?");
            
            string x = Console.ReadLine().ToLower();
            while (x != "no")
            {
                 Console.WriteLine("What is the grade");
                int numAnswer = Convert.ToInt32(Console.ReadLine());
                gradebook.Add(numAnswer);
                 Console.WriteLine("Add another");
                x = Console.ReadLine();
                
            }
            
            return gradebook;
         }
    }
} 