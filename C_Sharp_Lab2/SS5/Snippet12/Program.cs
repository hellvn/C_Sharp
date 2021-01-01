using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet12
{
    class Program
    {
        static void Main(string[] args)
        {
            Array objArray = Array.CreateInstance(typeof(string), 5);
            objArray.SetValue("Marketing", 0);
            objArray.SetValue("Finace", 1);
            objArray.SetValue("Human Resources", 2);
            objArray.SetValue("Information Technology", 3);
            objArray.SetValue("Bussiness Adimnistration", 4);
            for (int i = 0; i <= objArray.GetUpperBound(0); i++)
            {
                Console.WriteLine(objArray.GetValue(i));
            }
        }
    }
}
