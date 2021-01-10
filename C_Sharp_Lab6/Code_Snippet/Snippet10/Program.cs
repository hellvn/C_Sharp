using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet10
{
    interface ICalculate
    {
        double Area();
    }
    class Rectangle : ICalculate
    {
        float _length;
        float _breadth;
        public Rectangle(float valOne, float valTwo)
        {
            _length = valOne;
            _breadth = valTwo;
        }
        public double Area()
        {
            return _length * _breadth;
        }

        static void Main(string[] args)
        {
            Rectangle obj = new Rectangle(10.2F, 20.3F);
            if (obj is ICalculate)
            {
                Console.WriteLine("Area of rectangle: {0:F2}", obj.Area());
            }
            else
            {
                Console.WriteLine("Interface method not imlemented");
            }
        }
    }
}
