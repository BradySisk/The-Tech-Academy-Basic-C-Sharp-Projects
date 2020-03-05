using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you on?");
            string WhatCourse = Console.ReadLine();
            Console.WriteLine("What page number?");
            int PGnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need any help?    Please answer true or false");
            string Answer = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string PositiveEXP = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string Feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            int HRSstudyied = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thank you for your answers.An instructor will respond to this shortly.Have a great day!");
            Console.ReadLine();
        }
    }
}
