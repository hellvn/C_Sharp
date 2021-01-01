using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet23
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 23;
            Console.WriteLine("Cube of {0} = {1}", num, Cube(num));
        }
        static int Cube(int n)
        {
            return (n * n * n);
        }
    }
}

