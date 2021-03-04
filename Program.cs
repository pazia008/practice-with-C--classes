using System;
using System.Collections.Generic;


namespace classes
{

    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = new DateTime(2000, 12, 12);
            Company Dunder = new Company("Dunder Mifflin", start);

            Employee michael = new Employee()
            {
                FirstName = "Michael",
                LastName = "Scott",
                Title = "Regional Manager",
                StartDate = new DateTime(2001, 3, 6)
            };

            Employee pam = new Employee()
            {
                FirstName = "Pam",
                LastName = "Beasely",
                Title = "sales woman",
                StartDate = new DateTime(2001, 5, 9)
            };

            Employee andy = new Employee()
            {
                FirstName = "Andy",
                LastName = "Bernard",
                Title = "sales man",
                StartDate = new DateTime(2002, 6, 10)
            };

            List<Employee> workingEmployees = new List<Employee>()
            {
                michael, pam, andy
            };

            Dunder.CurrentEmployees = workingEmployees;

            foreach (Employee people in Dunder.CurrentEmployees)
            {
                Console.WriteLine($"{people.FirstName}  {people.LastName} works for {Dunder.Name} as {people.Title} since {people.StartDate}");

            }


        }
    }

};
