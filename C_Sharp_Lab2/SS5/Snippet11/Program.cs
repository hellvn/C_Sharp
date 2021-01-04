using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentName = new string[4] { "Ashley", "Joe", "Mikel","Vuong"};
            foreach (string studName in studentName)
            {
                Console.WriteLine("Congratulations!! " + studName + " you have been gratned an extra leave");
            }
        }
    }
}
