using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPrimer
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator orig = new Originator("stanje1");
            CareTaker care = new CareTaker(orig);
            care.save();
            orig.setState("stanje2");
            care.undo();
            Console.WriteLine(orig.getState());
        }
    }
}
