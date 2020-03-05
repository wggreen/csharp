using System;
using System.Collections.Generic;


namespace classes
{
    public class Company
    {
        public DateTime DateFounded { get; }

        public string Name { get; }

        public List<Employee> Employees = new List<Employee>();

        public void ListEmployees(Company company)
        {
            foreach (Employee employee in company.Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} works for {company.Name} as {employee.Title} since {employee.StartDate}");
            }
        }

        public void addEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public Company(string name, DateTime dateFounded)
        {
            Name = name;
            DateFounded = dateFounded;
        }
    }
}