using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet10
{
    sealed class Product
    {
        public int Quantity;
        public int Cost;
    }
    class Goods
    {
        static void Main(string[] args)
        {
            Product objProduct = new Product();
            objProduct.Quantity = 50;
            objProduct.Cost = 75;
            Console.WriteLine("Quantity of the Product:" + objProduct.Quantity);
            Console.WriteLine("Cost of the Product: " + objProduct.Cost);
        }
    }
}
