using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet12
{
    class Area
    {
        static int CalculateArea(int len, int wide)
        {
            return len * wide;
        }
        static double CalculateArea(double valOne, double valTwo)
        {
            return 0.5 * valOne * valTwo;
        }
        static void Main(string[] args)
        {
            int length = 10;
            int breadth = 22;
            double tbase = 2.5;
            double theight = 1.5;
            Console.WriteLine("Area of Rectangle:" + CalculateArea(length, breadth));
            Console.WriteLine("Area of triangle: " + CalculateArea(tbase, theight));
        }
    }
}
