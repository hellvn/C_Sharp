using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] count = new int[10];
            int counter = 0;
            for(int i = 0; i < 10; i++)
            {
                count[i] = counter++;
                Console.WriteLine("The count value is: " + count[i]);
            }
        }
    }
}
