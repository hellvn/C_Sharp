using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Animals
    {
        int Weight;
        string Name;

        public void SetMe(string Name, int Weight)
        {
            this.Name = Name;
            this.Weight = Weight;
        }
        public virtual void Show()
        {
            Console.WriteLine("\nName: {0}, Weight: {1}",Name, Weight);
        }
    }
    class Lion : Animals
    {
        public override void Show()
        {
            base.Show();
        }
    }
    class Tiger : Animals
    {
        public override void Show()
        {
            base.Show();
        }
    }
    
}
