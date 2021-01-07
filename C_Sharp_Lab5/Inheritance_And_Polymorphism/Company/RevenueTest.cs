using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class RevenueTest
    {
        static void Main(string[] args)
        {
            Revenue objRevenue = new Revenue();
            Expenditure objExpenditure = new Expenditure();

            objExpenditure.AcceptDetails();
            objExpenditure.DisplayDetails();

            objRevenue.AcceptDetails();
            objRevenue.DisplayDetails();
        }
    }
}
