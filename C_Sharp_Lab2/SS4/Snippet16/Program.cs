using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet16
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            int numOne;
            int numTwo;
            int result;
            for (; ; )
            {
                Console.WriteLine("Enter number one: ");
                numOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number two: ");
                numTwo = Convert.ToInt32(Console.ReadLine());
                result = numOne + numTwo;
                Console.WriteLine("Result of addtion: " + result);
                Console.WriteLine("Do you wist to continue[Y/M]");
                c = Convert.ToChar(Console.ReadLine());

                if (c == 'Y' || c == 'y')
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
