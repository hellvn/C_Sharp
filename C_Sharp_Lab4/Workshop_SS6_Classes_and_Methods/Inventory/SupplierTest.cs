using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class SupplierTest
    {
        static void Main(string[] args)
        {
            Inventory objSupplier = new Inventory();
            objSupplier.AcceptDetails();
            objSupplier.DisplayDetails();
        }
    }
}
