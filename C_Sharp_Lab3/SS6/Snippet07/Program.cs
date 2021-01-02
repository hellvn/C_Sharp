using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet07
{
    class Caculate
    {
        public static void Addition(int val1, int val2)
        {
            Console.WriteLine(val1 + val2);
        }
        public void Mutiply(int val1,int val2)
        {
            Console.WriteLine(val1 * val2);
        }
    }
    class StaticMethods
    {
        static void Main(string[] args)
        {
            Caculate.Addition(10, 50);
            Caculate objCal = new Caculate();
            objCal.Mutiply(10, 20);
        }
    }
}
