using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automotive
{
    class Toyota
    {
        static void Main(string[] args)
        {
            Category objCategory = new Category();
            SpareParts objSpareParts = new SpareParts();
            objCategory.Display();
            objSpareParts.Display();
        }
    }
}
