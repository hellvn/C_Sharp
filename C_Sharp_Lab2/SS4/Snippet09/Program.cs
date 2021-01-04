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
            int i = 0;
            int j;
            while (i <= 5)
            {
                j = 0;
                while (j <= i){
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
            Console.Read();
        }
    }
}
