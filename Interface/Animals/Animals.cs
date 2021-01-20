using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    interface IAnimal
    {
        void Habitat();
    }
    class Thang : IAnimal
    {
        public void Habitat()
        {
            Console.WriteLine("Can be housed with human beings");
        }
        static void Main(string[] args)
        {
            Thang objThang = new Thang();
            Console.Write(objThang.GetType().Name+" ");
            objThang.Habitat();
        }
    }
}
