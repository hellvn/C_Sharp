using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet09
{
    class Program
    {
        void StudentDetails()
        {
            Console.Write("Enter the number of Students: ");
            int noOfStds = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of Exmams: ");
            int exams = Convert.ToInt32(Console.ReadLine());
            string[] stdName = new string[noOfStds];
            string[,] details = new string[noOfStds, exams];
            for(int i = 0; i < noOfStds; i++)
            {
                Console.WriteLine();
                Console.Write("Enter the student Name: ");
                stdName[i] = Convert.ToString(Console.ReadLine());
                for(int y = 0; y < exams; y++)
                {
                    Console.Write("Enter Score in Exam" + (y + 1) + ": ");
                    details[i, y] = Convert.ToString(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine("Student Exam Details");
            Console.WriteLine("---------------------");
            Console.WriteLine();
            Console.WriteLine("Student\t\tMarks");
            Console.WriteLine("-------\t\t------");
            for(int i = 0; i < stdName.Length; i++)
            {
                Console.WriteLine(stdName[i]);
                for(int j = 0; j < exams; j++)
                {
                    Console.WriteLine("\t\t" + details[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Program objStudentsScore = new Program();
            objStudentsScore.StudentDetails();
        }
    }
}
