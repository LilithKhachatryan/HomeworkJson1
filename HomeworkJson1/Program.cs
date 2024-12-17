using System;
using System.Collections.Generic;
using HomeworkJson1.Models;
using HomeworkJson1.Utils;


namespace UniversityApp
{
    class Program
    {
        private const string FilePath = "data.json";

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, FullName = "Lilit Khachatryan", Age = 21},
                new Student { Id = 2, FullName = "Nelly Hakobyan", Age = 22 }
            };

            List<Employee> employees = new List<Employee>
            {
                new Employee { EmployeeId = 1, Name = "Michael", Department = "IT" }
            };

            University uni = new University { Name = "YSU", Location = "Yerevan" };

            Address address = new Address { Street = "Shahumyan", City = "Ararat", Country = "Armenia" };

            JsonHelper.WriteToFile(FilePath, students);
            JsonHelper.WriteToFile(FilePath, employees);

            Console.WriteLine("Data saved to JSON.");

            List<Student> loadedStudents = JsonHelper.ReadFromFile<Student>(FilePath);

            foreach (var student in loadedStudents)
            {
                Console.WriteLine(student);
            }
        }
    }
}
