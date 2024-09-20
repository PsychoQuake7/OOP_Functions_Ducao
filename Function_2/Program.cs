using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Program
    {

        public static void Main(string[] args)
        {
            LeapYear LY = new LeapYear();

            // Example year 
            int year = 2024;

            // Check if the year is a leap year
            bool isLeapYear = LY.IsLeapYear(year);

            LY.DisplayLeapYearResult(year, isLeapYear);

            Console.ReadKey();
        }
    }

    public class LeapYear
    {

        public bool IsLeapYear(int year)
        {
        
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }


        public void DisplayLeapYearResult(int year, bool isLeapYear)
        {
            if (isLeapYear)
            {
                Console.WriteLine(year + " is a leap year.");
            }
            else
            {
                Console.WriteLine(year + " is not a leap year.");
            }
        }

        public void DisplayProduct(int a, int b)
        {
            Console.WriteLine("Product is: " + Multiply(a, b));
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }

}
