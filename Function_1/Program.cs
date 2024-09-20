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
                heron hero = new heron();

                // Example sides 
                double a = 5;
                double b = 10;
                double c = 7;

                double area = hero.HeronTriangleArea(a, b, c);

                Console.WriteLine("The area of the triangle is: " + area);

                Console.ReadKey();
            
        }

        public class heron
        {
            public double HeronTriangleArea(double a, double b, double c)
            {
                double s = (a + b + c) / 2;

                double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

                return area;
            }

        }
    }

}
