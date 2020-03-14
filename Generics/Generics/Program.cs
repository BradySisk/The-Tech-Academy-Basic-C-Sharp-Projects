using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
      public  static void Main(string[] args)
        {
            Employee<int> employee = new Employee<int>();
            employee.things = new List<int>();
            employee.things.Add(88);
            employee.things.Add(46);
            employee.things.Add(21);

            Employee2<string> employee2 = new Employee2<string>();
            employee2.things = new List<string>();
            employee2.things.Add("Bobby");
            employee2.things.Add("Rupert");
            employee2.things.Add("Triston");
            foreach (string add in employee2.things)
            {
                Console.WriteLine(add);
                Console.ReadLine();
            }

            for (int i = 0; i < employee2.things.Length; i++) 
            {
                string add = employee2.things[i];
                Console.WriteLine(add);
                Console.ReadLine();
            }
            
          
        }
    }
}
