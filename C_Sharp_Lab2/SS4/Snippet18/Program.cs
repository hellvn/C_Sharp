using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet18
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] employeeNames = { "Maria", "Wilson", "Elton", "Garry" };
            Console.WriteLine("Employee Names");
            foreach (string names in employeeNames)
            {
                Console.WriteLine("{0} ", names);
            }
            Console.ReadLine();
        }
    }
}
