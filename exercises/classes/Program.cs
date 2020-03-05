using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee()
            {
                FirstName = "Millard",
                LastName = "Fillmore",
                Title = "Pope"
            };
            Employee employee2 = new Employee()
            {
                FirstName = "Kev",
                LastName = "TheDev",
                Title = "KITHGOD"
            };
            Employee employee3 = new Employee()
            {
                FirstName = "Scooby",
                LastName = "Doo",
                Title = "RutRoh"
            };

            Company company = new Company("Acme", DateTime.Now);

            company.addEmployee(employee1);
            company.addEmployee(employee2);
            company.addEmployee(employee3);

            company.ListEmployees(company);


        }
    }
}
