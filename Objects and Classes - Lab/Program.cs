using System;
using System.Collections.Generic;
using System.Linq;

namespace Objects_and_Classes___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main()
            {
                Student student = new Student("Georgi", 22);
                student.PropertyChanged += student_PropertyChanged;

                student.Name = "Pesho";
                student.Age = 21;

                string line = Console.ReadLine();
                while (line.ToLower() != "end")
                {
                    if (line.ToLower().Contains("name-") && line.Trim().Substring(5).Length > 2)
                    {
                        student.Name = line.Trim().Substring(5).Trim();
                    }

                    if (line.ToLower().Contains("age-"))
                    {
                        int age = 0;
                        if (int.TryParse(line.Substring(4), out age) && age > 0)
                        {
                            student.Age = age;
                        }
                    }

                    line = Console.ReadLine();
                }
            }
        }
    }
}
