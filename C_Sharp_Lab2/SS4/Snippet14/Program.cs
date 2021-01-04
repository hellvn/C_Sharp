using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet14
{
    class Program
    {
        static void Main(string[] args)
        {
            int investment;
            int returns;
            int expanses;
            int profit;
            int counter = 0;
            for (investment = 1000, returns = 0; returns < investment;)
            {
                Console.WriteLine("Enter the monthly expenditure");
                expanses = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the monthly profit");
                profit = Convert.ToInt32(Console.ReadLine());
                investment += expanses;
                returns += profit;
                counter++;
            }
            Console.WriteLine("Number ò months to break even: " + counter);
            Console.ReadLine();
        }
    }
}
