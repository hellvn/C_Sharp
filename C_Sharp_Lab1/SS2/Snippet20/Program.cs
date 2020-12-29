using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet20
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine("Short date and short time with seconds(G): {0:G}", dt);
            Console.WriteLine("Month and day(m):{0:m}", dt);
            Console.WriteLine("Short time(t):{0:t}", dt);
            Console.WriteLine("Short time with seconds (T):{0:T}", dt);
            Console.WriteLine("Year and Month(y):{0:y}", dt);
            Console.ReadLine();
        }
    }
}
