using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool boolTest = true;
            short byteTest = 19;
            int intTest;
            string stringTest = "David";
            float floatTest;
            intTest = 140000;
            floatTest = 14.5f;

            Console.WriteLine("boolTest={0}", boolTest);
            Console.WriteLine("byteTest=" + byteTest);
            Console.WriteLine("intTest=" + intTest);
            Console.WriteLine("stringTest=" + stringTest);
            Console.WriteLine("floatTest =" + floatTest);
            Console.ReadLine();
        }
    }
}
