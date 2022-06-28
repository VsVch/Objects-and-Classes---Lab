using System;
using System.Collections.Generic;
using System.Linq;

namespace PP05._Students_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] info = input.Split();
                string firstName = info[0];
                string lastname = info[1];
                int age = int.Parse(info[2]);
                string homeTown = info[3];

                if (IsStudentExisting(students, firstName, lastname))
                {
                    Student student = GetStudent(students, firstName, lastname);
                }
                else
                {
                    Student student = new Student()
                    {
                        FirstName = firstName,
                        LastName = lastname,
                        Age = age,
                        HomeTown = homeTown
                    };
                    students.Add(student);
                }

               
                input = Console.ReadLine();
            }

            string filterCity = Console.ReadLine();
            List<Student> filteredCity = students.Where(s => s.HomeTown == filterCity).ToList();
            foreach (Student student in filteredCity)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old");
            }
        }

        private static Student GetStudent(List<Student> students, string firstName, string lastname)
        {
            Student existingStudent = null;
            foreach (Student student in students)
            {
                if (student.FirstName == firstName & student.LastName == lastname)
                {
                    existingStudent = student;

                }
            }
            return existingStudent;
        }

        private static bool IsStudentExisting(List<Student> students, string firstName, string lastname)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName & student.LastName == lastname)
                {
                    return true;
                }
            }
            return false;
        }
    }
    class Student
    {
        public string FirstName{get; set;}
        public string LastName{get; set;}
        public int Age{get; set;}
        public string HomeTown { get; set; }
    }




}
