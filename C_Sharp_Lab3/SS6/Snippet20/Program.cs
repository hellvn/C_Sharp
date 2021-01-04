using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet20
{
    class Employee
    {
        private int _empID;
        private string _empName;
        private int _age;
        private double _salary;

        Employee(int id, string name, int age, double sal)
        {
            Console.WriteLine("Contructor for Employee called");
            _empID = id;
            _empName = name;
            _age = age;
            _salary = sal;
        }
        ~Employee()
        {
            Console.WriteLine("Destructor for Employee called");
        }

        static void Main(string[] args)
        {
            Employee objEmp = new Employee(1, "John", 45, 35000);
            Console.WriteLine("Employee ID: " + objEmp._empID);
            Console.WriteLine("Employee Name: " + objEmp._empName);
            Console.WriteLine("Age: " + objEmp._age);
            Console.WriteLine("Salary: " + objEmp._salary);
        }
    }
}
