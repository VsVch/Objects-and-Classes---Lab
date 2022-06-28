using System;
using System.Collections.Generic;
using System.Linq;

namespace P04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] data = input.Split();
                string firstName = data[0];
                string lastName = data[1];
                int age = int.Parse(data[2]);
                string town = data[3];

                Student student = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    HomeTown = town




                };
                students.Add(student);
                input = Console.ReadLine();
            }


            string filterHomeTown = Console.ReadLine();
            List<Student> filteStudent = students.Where(s => s.HomeTown == filterHomeTown).ToList();
            foreach (Student student in filteStudent)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old");
            }



        }
        class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string HomeTown { get; set; }
        
        
        }
    }
}
