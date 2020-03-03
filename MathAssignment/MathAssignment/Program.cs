using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a whole number to be multiplied by 50!:");
             int inputNum = Convert.ToInt32(Console.ReadLine());
            int TimesBy = 50;
            int Equals = inputNum * TimesBy;
            Console.WriteLine(Equals);
            Console.ReadLine();


            //  Console.WriteLine("Enter a whole number to be added to 25:");
            // int intputNum2 = Convert.ToInt32(Console.ReadLine());
            // int Add = 25;
            // int Equals2 = intputNum2 + Add;
            // Console.WriteLine(Equals2);
            // Console.ReadLine();

            //  Console.WriteLine("Enter a number to be divided by 12.5 ");
            //  int inputNum3 = Convert.ToInt32(Console.ReadLine());
            //  decimal DividedBy = 12.5;
            //  decimal total = inputNum3 / DividedBy;
            //  Console.WriteLine(total);
            //  Console.ReadLine();


            Console.WriteLine("Enter a number to see if its greater or less than 50!");
            int inputNum4 = Convert.ToInt32(Console.ReadLine());
            int NUM4 = 50;



            //bool trueOrFalse = 12 > 5;
            //Console.WriteLine(trueOrFalse.ToString());
            // Console.ReadLine();







        }
    }
}


//int total = 5 + 10;
//int otherTotal = 12 + 22;
//int combined = total + otherTotal;
//Console.WriteLine(combined);
//Console.ReadLine();


// Type your username and press enter
//Console.WriteLine("Enter username:");

// Create a string variable and get user input from the keyboard and store it in the variable
//string userName = Console.ReadLine();

// Print the value of the variable (userName), which will display the input value
//Console.WriteLine("Username is: " + userName);