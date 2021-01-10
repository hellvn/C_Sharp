using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet06
{
    interface ITerrestrialAnimal
    {
        void Eat();
    }
    interface IMarineAnimal
    {
        void Swim();
    }
    class Crocodile : ITerrestrialAnimal, IMarineAnimal
    {
        public void Eat()
        {
            Console.WriteLine("The Crocodile eats flesh");
        }
        public void Swim()
        {
            Console.WriteLine("The Crocodile can swim four times faster than an Olympic swimmer");
        }
        static void Main(string[] args)
        {
            Crocodile objCrocodile = new Crocodile();
            objCrocodile.Eat();
            objCrocodile.Swim();
        }
    }
    
}
