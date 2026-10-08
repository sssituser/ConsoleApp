using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Class12
    {
        static void Main (string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Ravi", Salary = 45000 },
                new Employee { Id = 2, Name = "Sita", Salary = 60000 },
                new Employee { Id = 3, Name = "Raj", Salary = 75000 },
                new Employee { Id = 4, Name = "Anu", Salary = 40000 },
                new Employee { Id = 5, Name = "Raju", Salary = 40000 }
            };

            int lowest = employees.OrderBy(e => e.Salary).Distinct().First().Salary;
            Console.WriteLine(lowest);


        }
    }

    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
