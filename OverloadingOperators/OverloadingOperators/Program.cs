using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperators
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.firstName = "Bob";
            employee.lastName = "Bobby";
            employee.ID = 55;

            Employee2 employee2 = new Employee2();
            employee2.firstName = "Dale";
            employee2.lastName = "Daley";
            employee2.ID = 88;

            Console.WriteLine(employee.ID == employee2.ID);
            Console.ReadLine();
        }
     

            

    }
}
