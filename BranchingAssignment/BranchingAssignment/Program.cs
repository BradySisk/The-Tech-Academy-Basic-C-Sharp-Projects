using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express.Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            int PackWgt = Convert.ToInt32(Console.ReadLine());
            if (PackWgt > 50)
                
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express.Have a good day.");
                Console.ReadLine();
                return;
            }
          
            
            
           
            
                
            
          
            
            Console.WriteLine("Please enter the package width:");
            int PackWit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package height:");
            int PackHT = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package length:");
            int PackLeng = Convert.ToInt32(Console.ReadLine());
            int DimenionsTotal = (PackHT * PackLeng * PackWit);
            if (DimenionsTotal > 100)
            {
                Console.WriteLine("Package is too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }
           


              Console.WriteLine("Your estimated total for shipping this package is:");
            int quote = (PackWgt * PackWit * PackLeng * PackHT / 100);
            Console.WriteLine(quote.ToString("C"));
            Console.ReadLine();




        }
    }
}
