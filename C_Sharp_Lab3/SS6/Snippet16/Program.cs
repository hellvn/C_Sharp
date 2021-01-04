using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet16
{
    class Program
    {
        string _empName;
        int _empAge;
        string _deptName;
        Program(string name, int num)
        {
            _empName = name;
            _empAge = num;
            _deptName = "Research & Development";
        }
        static void Main(string[] args)
        {
            Program objEmp = new Program("John", 10);
            Console.WriteLine(objEmp._deptName);
        }
    }
}
