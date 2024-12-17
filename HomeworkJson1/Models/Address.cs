using System;

namespace HomeworkJson1.Models
{
    public class Address
    {
        public string Street { get; set; } = default!;
        public string City { get; set; }=default!;
        public string Country { get; set; } = default!;

        public override string ToString() => $"{Street}, {City}, {Country}";
    }
}
