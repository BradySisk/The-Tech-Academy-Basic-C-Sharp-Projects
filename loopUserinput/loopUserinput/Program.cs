using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopUserinput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            int userInput = Convert.ToInt32(Console.ReadLine());

            List<int> numbers = new List<int>();
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(5);
            numbers.Add(7);




            try
            {
                foreach (int element in numbers)
                {
                    Console.WriteLine("Math operation result: " + (element / userInput));
                    Console.ReadLine();
                }

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error: " + e.Message);
               

            }
            catch (FormatException z)
            {
                Console.WriteLine("Error: " + z.Message);

            }

            Console.WriteLine("Thank for your time and hope you enjoyed the program, have a good day.");
            Console.ReadLine();
        }
    }
}
