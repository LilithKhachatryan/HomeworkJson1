using System;

namespace HomeworkJson1.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; } = default!;
        public string Department { get; set; } = default!;

        public override string ToString() => $"Employee: {Name}, Department: {Department}";
    }
}
