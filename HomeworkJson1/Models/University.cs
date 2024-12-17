using System;

namespace HomeworkJson1.Models
{   
    public class University
    {
        public string Name { get; set; } = default!;
        public string Location { get; set; } = default!;

        public override string ToString() => $"University: {Name}, Location: {Location}";
    }
}
