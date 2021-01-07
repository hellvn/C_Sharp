using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class WorkerTest
    {
        static void Main(string[] args)
        {
            Worker objWorker = new Worker();
            if (objWorker.InputDetails())
            {
                objWorker.DisplayDetails();
            }
        }
    }
}
