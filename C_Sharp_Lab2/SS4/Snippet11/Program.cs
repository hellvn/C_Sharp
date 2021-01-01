using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Even Numbers");
            for (num = 1; num <= 11; num++)
            {
                if ((num % 2) == 0)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
