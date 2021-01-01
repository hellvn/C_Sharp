using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            Console.WriteLine("Even Numbers");
            do
            {
                if ((num % 2) == 0)
                {
                    Console.WriteLine(num);
                }
                num = num + 1;
            }
            while (num <= 11);
            Console.ReadLine();
        }
    }
}
