using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //string Concat = "Hello my name is" + "Brady, i am a software" + "developer.";
            // Console.WriteLine(Concat);
            // Console.ReadLine();

            // string name = "brady";
            // name = name.ToUpper();
            // Console.WriteLine(name);
            // Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append ("My name is Brady.\n I'm hoping to become a successful software developer. \n I would also like to work on video games at some point, maybe even make my own.");

           
           
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
