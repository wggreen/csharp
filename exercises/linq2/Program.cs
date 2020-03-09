using System;
using System.Linq;
using System.Collections.Generic;

namespace linq2
{
    // Build a collection of customers who are millionaires
    public class Customer
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string Bank { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            List<Customer> customers = new List<Customer>()
            {
            new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
            };

            IEnumerable<Customer> millionaires = customers.Where(customer => customer.Balance >= 1000000);

            var millionairesPerBank = millionaires
                .GroupBy(millionaire => millionaire.Bank);

            foreach (var group in millionairesPerBank)
            {
                Console.WriteLine($"{group.Key}: {group.Count()}");
            }
            // .ForEach(group =>
            // {
            //     Console.WriteLine($"{group.Key}: {group.Count()}");
            // });


        }
    }
}
