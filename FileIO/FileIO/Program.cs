using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:\Users\Mark Wahlbang\Logs\Log.txt", true))
            {
                file.WriteLine(userInput);
            }
            string text = File.ReadAllText("C:\\Users\\Mark Wahlbang\\Logs\\Log.txt");
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}


