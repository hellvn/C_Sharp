using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet14
{
    class Program
    {
        double _length;
        double _breadth;
        public double Area(double _length, double _breadth)
        {
            this._length = _length;
            this._breadth = _breadth;
            return _length * _length;
        }
        static void Main(string[] args)
        {
            Program objDimension = new Program();
            Console.WriteLine("Area of retangle = " + objDimension.Area(10.5, 12.5));
        }
    }
}
