using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Using_Overloading
{
    class SupplierTest
    {
        static void Main(string[] args)
        {
            Supplier objSupplier = new Supplier();
            objSupplier.AcceptDetails();

            int id = 0;
            string name = "";

            Console.Write("\nEnter the id of the supplier: ");
            id = Convert.ToInt32(Console.ReadLine());

            objSupplier.DisplayDetails(id);

            Console.Write("\nEnter the name of the supplier: ");
            name = Console.ReadLine();

            objSupplier.DisplayDetails(name);

            objSupplier.DisplayDetails(id, name);
        }
    }
}
