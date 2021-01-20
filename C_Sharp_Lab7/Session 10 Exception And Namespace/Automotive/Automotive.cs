using System;
using System.Collections.Generic;
using System.Text;
using Utility_Vehicle.Car;
using Utility_Vehicle = Automotive.Vehicle.Jeep;

namespace Automotive
{
    namespace Vehicle
    {
        namespace Jeep
        {
            class Category
            {
                string _category;
                public Category()
                {
                    _category = "Multi Utility Vehicle";
                }
                public void Display()
                {
                    Console.WriteLine("Jeep Category: " + _category);
                }
            }
            
        }
        class Automotive
        {
            static void Main(string[] args)
            {
                Category objCat = new Category();
                objCat.Display();
                Utility_Vehicle.Category objCategory = new Utility_Vehicle.Category();
                objCategory.Display();
            }
        }

    }
    
}
