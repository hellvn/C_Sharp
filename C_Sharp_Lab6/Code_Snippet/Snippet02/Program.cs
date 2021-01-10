using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet02
{
    abstract class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Every animal eats food in order to servive");
        }
        public abstract void AnimalSound();
    }
    class Lion : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Lion roars");
        }
        static void Main(string[] args)
        {
            Lion obj = new Lion();
            obj.AnimalSound();
            obj.Eat();
        }
    }
}
