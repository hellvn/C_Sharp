using System;

namespace GeometryExample
{
    class Cylinder
    {
        public double Radius;
        public double Height;
        public double BArea;
        public double LArea;
        public double TArea;
        public double Volume;

        public void Process()
        {
            BArea = (Radius * Radius * Math.PI);
            LArea = 2 * Math.PI * Radius * Height;
            TArea = 2 * Math.PI * Radius * (Height + Radius);
            Volume = Math.PI * Radius * Radius * Height;
        }
        public void Result()
        {
            Console.WriteLine("\nCylinder Characteristics");
            Console.WriteLine("Radius: {0}, Height: {1}", Radius, Height);
            Console.WriteLine("Base: {0:f} | Lateral: {1:f} | Total: {2:f} | Volume: {3:f}", BArea , LArea, TArea, Volume);
        }
        public static void Main(string[] args)
        {
            Cylinder cylinder = new Cylinder();
            Console.WriteLine("Enter the dimenstions of cylinder");
            Console.Write("Radius: ");
            cylinder.Radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height: ");
            cylinder.Height = Convert.ToDouble(Console.ReadLine());
            cylinder.Process();
            cylinder.Result();
        }
    }
}
