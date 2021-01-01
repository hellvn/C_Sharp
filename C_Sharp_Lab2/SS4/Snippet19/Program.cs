using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet19
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = 17;
            int numtwo = 2;

            while (numtwo <= numOne - 1)
            {
                if (numOne % numtwo == 0)
                {
                    Console.WriteLine("Not a prime number");
                    break;
                }
                numtwo++;

                if (numtwo == numOne)
                {
                    Console.WriteLine("Prime number");
                }
            }
        }
    }
}
