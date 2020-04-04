using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee()
            {
                ID = 1,
                firstName = "Joe",
                lastName = "Bob"
            };
            Employee emp2 = new Employee()
            {
                ID = 2,
                firstName = "Jules",
                lastName = "Julie"
            };
            Employee emp3 = new Employee()
            {
                ID = 3,
                firstName = "Joe",
                lastName = "Talks"
            };
            Employee emp4 = new Employee()
            {
                ID = 4,
                firstName = "Poppy",
                lastName = "Seeds"
            };
            Employee emp5 = new Employee()
            {
                ID = 5,
                firstName = "Charlie",
                lastName = "Candymountian"
            };
            Employee emp6 = new Employee()
            {
                ID = 6,
                firstName = "Yasuo",
                lastName = "Ninja"
            };
            Employee emp7 = new Employee()
            {
                ID = 7,
                firstName = "Amber",
                lastName = "Hef"
            };
            Employee emp8 = new Employee()
            {
                ID = 8,
                firstName = "Daren",
                lastName = "Darius"
            };
            Employee emp9 = new Employee()
            {
                ID = 9,
                firstName = "Elena",
                lastName = "Shiperd"
            };
            Employee emp10 = new Employee()
            {
                ID = 10,
                firstName = "Ty",
                lastName = "Kook"
            };

            List<Employee> employees = new List<Employee>();
            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);
            employees.Add(emp4);
            employees.Add(emp5);
            employees.Add(emp6);
            employees.Add(emp7);
            employees.Add(emp8);
            employees.Add(emp9);
            employees.Add(emp10);


            foreach (Employee employee in employees)
            {
                if (employee.firstName == "Joe") ;
                {
                    Console.WriteLine(employee);
                    Console.ReadLine();
                }
            }
        }
    }
}
