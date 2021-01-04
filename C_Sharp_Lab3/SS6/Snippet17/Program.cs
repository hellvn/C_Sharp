using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet17
{
    class Product
    {
        static int _valueOne = 10;
        static int _product;
        static Product()
        {
            Console.WriteLine("Static Constructor initialized");
            _product = _valueOne * _valueOne;
        }
        public static void Method()
        {
            Console.WriteLine("Value of product = " + _product);
        }
        static void Main(string[] args)
        {
            Product.Method();
        }
    }
}
