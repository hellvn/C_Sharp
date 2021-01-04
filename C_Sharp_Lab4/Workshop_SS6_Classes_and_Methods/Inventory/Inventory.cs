using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class Inventory
    {
        private int _supplierID;
        private string _supplierName;
        private string _city;
        private string _phoneNo;
        private string _email;
        
        public void AcceptDetails()
        {
            Console.Write("Enter the ID of Supplier: ");
            _supplierID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the name of supplier: ");
            _supplierName = Console.ReadLine();
            Console.Write("Enter the name of city: ");
            _city = Console.ReadLine();
            Console.Write("Enter phone No.: ");
            _phoneNo = Console.ReadLine();
            Console.Write("Enter email address: ");
            _email = Console.ReadLine();
        }
        public void DisplayDetails()
        {
            Console.WriteLine("\nSupplier Details: ");
            Console.WriteLine("Supplier ID: " + _supplierID);
            Console.WriteLine("Supplier Name: " + _supplierName);
            Console.WriteLine("City: " + _city);
            Console.WriteLine("Phone No: " + _phoneNo);
            Console.WriteLine("Email: " + _email);
        }
    }
}
