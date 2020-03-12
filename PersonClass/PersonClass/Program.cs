using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    class Program
    {
       public static void Main(string[] args)
        {
          Person person = new Person();
            person.FirstName = "Lost";
            person.LastName = "Sanity";
            person.SayName();
            Console.ReadLine();

            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.ID = 54;
            employee.SayName();
            Console.ReadLine();


           

           
           

           

           
         
        }
    }
}
