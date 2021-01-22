using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion();
            Tiger tiger = new Tiger();
            tiger.SetMe("tiger", 100);
            tiger.Show();

            lion.SetMe("lion", 200);
            lion.Show();
        }
    }
}
