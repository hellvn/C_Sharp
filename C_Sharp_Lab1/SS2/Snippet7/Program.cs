using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///<summary>
///The program demonstrate the use of XML comments.
///Employee class uses constructors to initialized the ID and
///name of the employee adn displays them.
///</summary>
///<remarks>
///THis is program uses both parameterized and 
///non-parameterized constructors.
/// </remarks>

namespace Snippet7
{
    class Employee  
    {
        ///<summary>
        ///Integer field to store employee ID
        ///</summary>
        private int _id;
        ///<summary>
        ///String field to store employee name
        /// </summary>
        private string _name;
        ///<summary>
        ///This constructor initializes the id and name,
        /// </summary>
        /// <remarks>
        /// <seealso cref="Employee(int,string)">Employee(int,string)</seealso>
        /// </remarks> 
        public Employee()
        {
            _id = -1;
            _name = null;
        }
        ///<summary>
        ///This constructor initializes the id and name.
        ///(<paramref name="id"/>,<paramred name="name"/>).
        /// </summary>
        /// <param name="id">Employee ID</param>
        /// <param name="name">Employee Name</param>
        public Employee(int id, string name)
        {
            this._id = id;
            this._name = name;
        }
        ///<summary>
        ///The entry point for the application.
        ///<param name="args">A list of command line arguments</param>
        /// </summary>
        static void Main(string[] args)
        {
            //creating an object of Employee class and displaying the
            //id and name of the employee
            Employee objEmp = new Employee(101, "David Smith");
            Console.WriteLine("Employee ID: {0} \nEmployee Name : {1} ",
                objEmp._name);
        }
    }
}
