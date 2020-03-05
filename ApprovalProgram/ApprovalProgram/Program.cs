using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprovalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 15;
             int tickets = 3;
           


            Console.WriteLine("What is your age?");
            int UserAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a dui?");
            bool Answer = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many tickets do you have?");
            int UserTickets = Convert.ToInt32(Console.ReadLine());
            bool Applicant = (UserAge > age && Answer && UserTickets < tickets);
            Console.WriteLine("Qualified?");
            Console.WriteLine(Applicant);
            Console.ReadLine();
        }
    }
}
