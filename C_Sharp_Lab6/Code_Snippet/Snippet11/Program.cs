using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet11
{
    interface ISet
    {
        void AcceptDetails(int valOne, string valTwo);
    }
    interface IGet
    {
        void Display();
    }

    class Employee : ISet
    {
        int _impID;
        string _impName;
        public void AcceptDetails(int valOne, string valTwo)
        {
            _impID = valOne;
            _impName = valTwo;
        }
        static void Main(string[] args)
        {
            Employee obj = new Employee();
            obj.AcceptDetails(10, "Jack");
            IGet objGet = obj as IGet;
            if (objGet != null)
            {
                objGet.Display();
            }
            else
            {
                Console.WriteLine("Invalid casting  occurred");
            }
        }
    }
}
