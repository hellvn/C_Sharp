using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noertis_Pharma
{
    class Test
    {
        static void Main(string[] args)
        {
            Medicine obj = new Medicine(101, "Boganic", "Tam Binh", 32, 50, new DateTime(01 / 10 / 2020), new DateTime(01 / 10 / 2021), 300);
            Medicine obj1 = new Medicine();
            Medicine obj2 = obj1.Accept();
            obj2.Print();
            obj.Print(101);
            obj.Print(101, "Boganic");

            Sales Sale = new Sales(101, "Boganic", 23, 13, 10, "Ha Noi");
            Sale.Display();
            Sale.Display(101);
            Sales Sale1 = new Sales();
            Sales Sale2 = Sale1.Accept();
            Sale2.Accept();
        }
    }
}
