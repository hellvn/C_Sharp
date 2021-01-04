using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet19
{
    class Employee
    {
        private int _empId;
        private string _empName;
        private int _age;
        private double _salary;
        Employee(int id, string name, int age, double sal)
        {
            Console.WriteLine("Constructor for Employee called");
            _empId = id;
            _empName = name;
            _age = age;
            _salary = sal;
        }
        ~Employee()
        {
            Console.WriteLine("Destructor for employee called");
        }
        static void Main(string[] args)
        {
            Employee objEmp = new Employee(1, "John", 45, 35000);
            Console.WriteLine("Employee ID: " + objEmp._empId);
            Console.WriteLine("Employee Name: " + objEmp._empName);
            Console.WriteLine("Age:" + objEmp._age);
            Console.WriteLine("Salary: " + objEmp._salary);
        }
    }
}
