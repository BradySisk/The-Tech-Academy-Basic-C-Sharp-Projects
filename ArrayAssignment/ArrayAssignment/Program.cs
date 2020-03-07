using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // string[] StringArray = new string[] { "Thor", "Son", "Of", "Odin" };
            // Console.WriteLine("Please select an index of the array to be displayed.");
            // int UserInputS = Convert.ToInt32(Console.ReadLine());

            //if (UserInputS >= 0 && UserInputS < 5)
            // {
            //     Console.WriteLine(StringArray[UserInputS]);
            // }


            //    else
            //         {

            //         Console.WriteLine("The number you entered is out of bounds of the array.");
            // }
            // Console.ReadLine();


            // int[] IntArray = new int[] { 55, 44, 11, 31, 88 };
            // Console.WriteLine("Please select an index of the array to be displayed.");

            //int[] IntArray = new int[] { 44, 88, 99, 31, };
            //Console.WriteLine("Please select an index to be displayed.");
            //int UserInput2 = Convert.ToInt32(Console.ReadLine());

            //if (UserInput2 >= 0 && UserInput2 < 5)
            //{
            //    Console.WriteLine(IntArray[UserInput2]);
            //}
            //else
            //{
            //    Console.WriteLine("The number you entered is out of bounds of the array.");
            //}
            //Console.ReadLine();

            List<string> StringList = new List<string>();
            StringList.Add("Thor");
            StringList.Add("Son");
            StringList.Add("Of Odin");

            Console.WriteLine("Please select an index to be displayed.");
            int UserInput3 = Convert.ToInt32(Console.ReadLine());

            if (UserInput3 >= 0 && UserInput3 <5)
            {
                Console.WriteLine(StringList[UserInput3]);
            }
           else
            {
                Console.WriteLine("The number you entered is out of bounds of the array.");
            }
            Console.ReadLine();
        }
    }
}

