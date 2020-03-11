using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsMore
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please select a number to math operations with.");
            int number = Convert.ToInt32(Console.ReadLine());

            Class1 Math = new Class1();
            Math.Multiply(number);
            Math.Subtract(number);
            Math.Add(number);

            int result1 = Math.Multiply(number);
            int result2 = Math.Add(number);
            int result3 = Math.Subtract(number);

            Console.WriteLine($"{ result1} { result2} { result3}");
            Console.ReadLine();




           
        }
    }
}
