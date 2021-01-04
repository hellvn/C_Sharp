using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet06
{
    class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal constructor without parameters");
        }
        public Animal(String name)
        {
            Console.WriteLine("Animal constructor with a string parameter");
        }
    }
    class Cannie : Animal
    {
        public Cannie() : base("Lion")
        {
            Console.WriteLine("Derived Cannie");
        }
    }
    class Details
    {
        static void Main(string[] args)
        {
            Cannie objCannie = new Cannie();
        }
    }
}
