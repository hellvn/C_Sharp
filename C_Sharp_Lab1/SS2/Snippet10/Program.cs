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
            string path = "C:\\Windows\\MyFile.txt";
            bool found = true;
            if (found)
            {
                Console.WriteLine("File Path: \'" + path + "\'");
            }
            else
            {
                Console.WriteLine("File Not Found!\a");
            }
        }
    }
}
