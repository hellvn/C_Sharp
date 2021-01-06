using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noertis_Pharma
{
    class Sales
    {
        int MedicneCode;
        string MedicineName;
        int qtySold;
        int plannedSale;
        int actSale;
        string region;
        public Sales(int code, string name, int qSold, int planSale, int actSale, string region)
        {
            this.MedicneCode = code;
            this.MedicineName = name;
            this.qtySold = qSold;
            this.plannedSale = planSale;
            this.actSale = actSale;
            this.region = region;
        }
        public Sales()
        {

        }

        public Sales Accept()
        {
            Console.Write("Enter medicine code: ");
            MedicneCode = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Medicine name: ");
            MedicineName = Console.ReadLine();
            Console.Write("Enter sold quantity: ");
            qtySold = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter planned sale: ");
            plannedSale = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter actual sale: ");
            actSale = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter region: ");
            region = Console.ReadLine();
            Sales objSale = new Sales(MedicneCode, MedicineName, qtySold, plannedSale, actSale, region);
            return objSale;

        }

        public void Display()
        {
            Console.WriteLine("Medicine code: " + MedicneCode);
            Console.WriteLine("Medicine Name: " + MedicineName);
            Console.WriteLine("Sold Quantity: " + qtySold);
            Console.WriteLine("Planned sales: " + plannedSale);
            Console.WriteLine("Actual sales: " + actSale);
            Console.WriteLine("Region: " + region);
        }

        public void Display(int code)
        {
            if (MedicneCode == code)
            {
                Console.WriteLine("Different compare to plan: {0}", actSale - plannedSale);
                if (actSale - plannedSale > 0)
                {
                    Console.WriteLine("Amazing good job");
                }
                else
                {
                    Console.WriteLine("Mission failed");
                }
            }
            else
            {
                Console.WriteLine("Cannot find the Medicine code");
            }
        }
    }
}
