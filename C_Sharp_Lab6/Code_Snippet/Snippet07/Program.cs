using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet07
{
    interface ITerestrialAnimal1
    {
        string Eat();
    }
    interface IMarineAnimal
    {
        string Eat();
    }
    class Crocodile : ITerestrialAnimal1, IMarineAnimal
    {
        string ITerestrialAnimal1.Eat()
        {
            string terCroc = "Crocodile eats other animals";
            return terCroc;
        }
        string IMarineAnimal.Eat()
        {
            string marCroc = "Crocodile eats fish and marine animals";
            return marCroc;
        }
        public string EatTerrestrial()
        {
            ITerestrialAnimal1 objTerAnimal;
            objTerAnimal = this;
            return objTerAnimal.Eat();
        }
        public string EatMarine()
        {
            IMarineAnimal objMarAnimal;
            objMarAnimal = this;
            return objMarAnimal.Eat();
        }
        static void Main(string[] args)
        {
            Crocodile objCrocodile = new Crocodile();
            string terCroc = objCrocodile.EatTerrestrial();
            Console.WriteLine(terCroc);
            string marCroc = objCrocodile.EatMarine();
            Console.WriteLine(marCroc);
        }

    }
}
