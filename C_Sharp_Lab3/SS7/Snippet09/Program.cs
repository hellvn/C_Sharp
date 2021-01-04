using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet09
{
    class Student
    {
        string _studentName = "James";
        string _address = "California";
        public virtual void PrintDetails()
        {
            Console.WriteLine("Student Name:" + _studentName);
            Console.WriteLine("Address:" + _address);
        }
    }
    class Grade : Student
    {
        string _class = "Four";
        float _percent = 71.25F;
        public override void PrintDetails()
        {
            Console.WriteLine("Class:" + _class);
            Console.WriteLine("Percentage:" + _percent);
        }
        static void Main(string[] args)
        {
            Student objStudent = new Student();
            Grade objGrade = new Grade();
            objStudent.PrintDetails();
            objGrade.PrintDetails();
        }
    }
}
