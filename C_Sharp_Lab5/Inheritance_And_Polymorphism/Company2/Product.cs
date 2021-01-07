using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company2
{
    class Product : Invoice
    {
        private string _productName;
        private int _quantity;
        private double _price;
        private double _totalValue;

        public override void SetDetails()
        {
            base.SetDetails();
            Console.Write("Enter the product name: ");
            _productName = Console.ReadLine();

        Sale:
            Console.Write("Enter the quantity sold: ");
            _quantity = Convert.ToInt32(Console.ReadLine());
            if (_quantity < 0)
            {
                Console.WriteLine("Quantity cannot be negative");
                goto Sale;
            }
        Price:
            Console.Write("Enter price per unit: ");
            _price = Convert.ToDouble(Console.ReadLine());
            if (_price < 0)
            {
                Console.WriteLine("Price cannot be negative");
                goto Price;
            }

            _totalValue = _quantity * _price;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("\nPRODUCT DETAIS");
            Console.WriteLine("\nProduct:\t" + _productName);
            Console.WriteLine("Quantity Sold:\t" + _quantity);
            Console.WriteLine("Price Per Unit:\t" + _price);
            Console.WriteLine("Total Amount:\t" + _totalValue);
        }
    }
}
