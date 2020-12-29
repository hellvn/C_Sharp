using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet09
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "\u0048\u0065\u006C\u006F";
            Console.WriteLine("\t" + str + "!\n");
            Console.WriteLine("David\u0020\"2007\"");
        }
    }
}
