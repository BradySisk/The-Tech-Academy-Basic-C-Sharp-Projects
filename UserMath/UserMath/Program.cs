using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserMath
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


              Console.WriteLine("Enter a whole number to be added to 25:");
             int intputNum2 = Convert.ToInt32(Console.ReadLine());
             int Add = 25;
             int Equals2 = intputNum2 + Add;
             Console.WriteLine(Equals2);
             Console.ReadLine();

              Console.WriteLine("Enter a number to be divided by 12.5 ");
              int inputNum3 = Convert.ToInt32(Console.ReadLine());
              double DividedBy = 12.5;
              double total = inputNum3 / DividedBy;
              Console.WriteLine(total);
              Console.ReadLine();


            Console.WriteLine("Enter a number to see if its greater or less than 50!");
            int inputNum4 = Convert.ToInt32(Console.ReadLine());
            bool trueOrFalse = inputNum4 > 50;
            Console.WriteLine(trueOrFalse.ToString());
            Console.ReadLine();

            Console.WriteLine("Please enter a number to be divided by 7 to get an reaminder ");
            int inputNum5 = Convert.ToInt32(Console.ReadLine());
            int equals5 = inputNum5 % 7;
            Console.WriteLine(equals5);
            Console.ReadLine();


          


        }
    }
}
