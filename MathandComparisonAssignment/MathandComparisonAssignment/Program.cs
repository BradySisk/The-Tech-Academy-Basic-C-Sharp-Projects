using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathandComparisonAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int salary1 = 15 * 40 * 52;
            int salary2 = 20 * 40 * 52;
            int hrRate1 = 15;
            int weeklyHrs1 = 40;
            int hrRate2 = 20;
            int weeklyHrs2 = 40;
          

            Console.WriteLine("Anonymous income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            Console.WriteLine(hrRate1);
            Console.WriteLine("Hours worked per week?");
            Console.WriteLine(weeklyHrs1);
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly rate");
            Console.WriteLine(hrRate2);
            Console.WriteLine("Hours worked per week?");
            Console.WriteLine(weeklyHrs2);
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(salary1);
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(salary2);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool MakesMore = salary1 > salary2;
            Console.WriteLine(MakesMore);
            Console.ReadLine();
           

        }
    }
}


