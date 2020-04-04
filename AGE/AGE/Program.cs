using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGE
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter your age.");
                int userAge = Convert.ToInt32(Console.ReadLine());
                var year = DateTime.Now.Year;
                var birthyear = year - userAge;
                if (userAge == 0)
                {
                    throw new CustomException("number cannot be zero");
                    Console.ReadLine();
                }
                if (userAge < 0) ;
                {
                    throw new CannotUseNegativeNumbers("cannot use negative numbers");
                    Console.ReadLine();
                }
                Console.WriteLine("Year you were born is." + birthyear);
                Console.ReadLine();
            }
            catch (CustomException)
            {
                Console.WriteLine("number cannot be 0 ");
                Console.ReadLine();
            }
            catch (CannotUseNegativeNumbers)
            {
                Console.WriteLine("cannot use negative numbers");
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("Im sorry, something went wrong please try again. :) ");
                Console.ReadLine();
            }
            

        }
    }
}
