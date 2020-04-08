using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_and_loop_and_list_and_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Please enter a name.");
                string userInput = Console.ReadLine();

                string[] names = { "Jeff", "Keplen", "Sarah", "Francine" };

                for (int j = 0; j < names.Length; j++)
                {
                    Console.WriteLine(names[j] + userInput);

                }
                Console.ReadLine();
            }
        }
    }
}