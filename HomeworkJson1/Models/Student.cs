using System;

namespace HomeworkJson1.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; } = default!;
        public int Age { get; set; }

        public override string ToString() => $"Student: {FullName}, Age: {Age}";
    }
}
