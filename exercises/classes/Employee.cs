using System;

namespace classes
{
    public class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Title { get; set; }

        public DateTime StartDate { get; set; } = DateTime.Now;
    }
}