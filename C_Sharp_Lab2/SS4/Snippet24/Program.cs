using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet24
{
    class Program
    {
        static void Main(string[] args)
        {
            int yrsOfService = 5;
            double salary = 1250;
            double bonus = 0;
            if (yrsOfService <= 5)
            {
                bonus = 50;
                return;
            }
            else
            {
                bonus = salary * 0.2;
            }
            Console.WriteLine("Salary amount: " + salary);
            Console.WriteLine("Bonus amount: " + bonus);
        }
    }
}
