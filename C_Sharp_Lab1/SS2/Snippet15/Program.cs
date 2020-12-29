using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet15
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            int age;
            double salary;
            Console.Write("Enter your name: ");
            userName = Console.ReadLine();
            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your salary: ");
            salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Name: {0}, Age:{1}, Salary: {2}", userName, age, salary);
        }
    }
}
