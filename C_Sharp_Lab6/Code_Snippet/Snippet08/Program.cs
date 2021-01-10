using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet08
{
    interface IAnimal
    {
        void Drink();
    }
    interface InCarnivorous
    {
        void Eat();
    }
    interface IReptile : IAnimal, InCarnivorous
    {
        void Habitat();
    }
    class Crocodile : IReptile
    {
        public void Drink()
        {
            Console.WriteLine("Drinks fresh water");
        }
        public void Habitat()
        {
            Console.WriteLine("Can stay in Water and Land");
        }
        public void Eat()
        {
            Console.WriteLine("Eats Flesh");
        }

        static void Main(string[] args)
        {
            Crocodile objCrocodile = new Crocodile();
            Console.WriteLine(objCrocodile.GetType().Name);
            objCrocodile.Habitat();
            objCrocodile.Eat();
            objCrocodile.Drink();
        }
    }
}
