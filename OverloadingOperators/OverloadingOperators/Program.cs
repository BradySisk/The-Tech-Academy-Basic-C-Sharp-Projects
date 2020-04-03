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
            Employee emp1 = new Employee(1, "Bob");
            emp1.Display();

            Employee emp2 = new Employee(2, "Shirly");
            emp2.Display();

            Console.WriteLine(emp1 == emp2);
            Console.WriteLine(emp1 != emp2);
            Console.ReadLine();
            
        }
       
    }
}
