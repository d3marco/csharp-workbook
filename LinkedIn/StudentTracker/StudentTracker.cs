using System;
using System.Collections.Generic;

namespace StudentTracker
{
    class Program
    {
        static void Main(string[] args)
        {



            var students = new List<Student>();
            var adding = true;
            while (adding)
            {
                var newStudent = new Student();

                Console.WriteLine("Student Name:");
                newStudent.Name = Console.ReadLine();

                Console.WriteLine("Student Grade:");
                newStudent.Grade = int.Parse(Console.ReadLine());


                Console.WriteLine("Student Birthday:");
                newStudent.Birthday = Console.ReadLine();

                Console.WriteLine("Student Address:");
                newStudent.Address = Console.ReadLine();


                Console.WriteLine("Student Phone number:");
                newStudent.Phone = int.Parse(Console.ReadLine());


                Student.Count++;
                Console.WriteLine("Student count: {0}", Student.Count);

                Console.WriteLine("Add another y/n?");
                if (Console.ReadLine() != "y")

                    adding = false;
                students.Add(newStudent);

            }
            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);
            }
        }


    }
    class Member
    {
        public string Name;
        public string Address;
        protected string Phone;
          public int Phone
        {
            set { phone = value; }
        }

    }
    public class Student: Member
    {

        static public int Count;
        public string Name;
        public int Grade;
        public string Birthday;
        public string Address;
        private int phone;

        public Student(string name, int grade, string birthday, string address, int phone)
        {
            Phone = phone;
            Grade = grade;
            Birthday = birthday;
            Address = address;
            Phone = phone;
        }
        public Student()
        {

        }

      
    }
    class Teacher : Member
    {
    
        public string Subject;
    }

}

