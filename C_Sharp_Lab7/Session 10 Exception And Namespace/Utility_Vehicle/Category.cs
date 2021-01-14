using System;
using System.Collections.Generic;
using System.Text;

namespace Utility_Vehicle
{
    namespace Car
    {
        class Category
        {
            string _category;
            public Category()
            {
                _category = "Luxury Vehicle";
            }
            public void Display()
            {
                Console.WriteLine("Car Category: " + _category);
            }
        }
    }
}
