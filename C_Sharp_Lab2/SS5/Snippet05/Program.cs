using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet05
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3] { "James", "Alex", "Fernando" };
            for(int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }
        }
    }
}
