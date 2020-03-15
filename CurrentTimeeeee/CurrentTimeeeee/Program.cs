using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrentTimeeeee
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;




            Console.WriteLine(now);
            Console.WriteLine("Please enter a number");
            int userInput = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine(now.AddHours(userInput).ToString());
            Console.ReadLine();
        }
    }
}
