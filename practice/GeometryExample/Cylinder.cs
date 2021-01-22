using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryExample
{
    class Cylinder
    {
        public double Radius;
        public double Height;
        public static void Main(string[] args)
        {
            Cylinder objCylinder = new Cylinder();
            Console.WriteLine("Enter the dimenstions of cylinder");
            Console.Write("Radius: ");
            objCylinder.Radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height: ");
            objCylinder.Height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nCylinder Characteristics");
            Console.WriteLine("Radius: {0}, Height: {1}", objCylinder.Radius, objCylinder.Height);
            Console.WriteLine("Base: {0:f} | Lateral: {1:f} | Total: {2:f} | Volume: {3:f}", objCylinder.BaseArea(), objCylinder.LateralArea(), objCylinder.TotalArea(), objCylinder.Volume());
        }
        public double BaseArea()
        {
            double BArea;
            BArea = (Radius * Radius * Math.PI);
            return BArea;
        }
        public double LateralArea()
        {
            double LArea;
            LArea = 2 * Math.PI * Radius * Height;
            return LArea;
        }
        public double TotalArea()
        {
            double TArea;
            TArea = 2 * Math.PI * Radius * (Height + Radius);
            return TArea;
        }
        public double Volume()
        {
            double Volume;
            Volume = Math.PI * Radius * Radius * Height;
            return Volume;
        }
        
    }
}
