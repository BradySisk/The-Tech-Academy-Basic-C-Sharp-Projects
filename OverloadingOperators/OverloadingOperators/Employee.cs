using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperators
{

    class Employee
    {
        public int id;
        public string firstName;

        public Employee(int id, string firstName)
        {
            this.id = id;
            this.firstName = firstName;
        }
        public void Display()
        {
            Console.WriteLine("ID:" + id);
            Console.WriteLine("FirstName: " + firstName);
        }
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            bool EMPID = (emp1.id == emp2.id);
            Console.WriteLine("The employess's id's do match.");
            return EMPID;




        }

        public static bool operator !=(Employee emp1, Employee emp2)
        {
            bool EMPID = (emp1.id != emp2.id);
            Console.WriteLine("The id's do not match");
            return EMPID;


        }


    }
}
