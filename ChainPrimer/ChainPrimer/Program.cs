using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainPrimer
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem problem = new Problem("Obrisani fajlovi", Problem.ProblemType.HARD);
            Handler automat = new Automat();
            Handler teh = new TechSupport();
            Handler eng = new Engineer();
            automat.SetNext(teh);
            teh.SetNext(eng);
            automat.Handle(problem);
        }
    }
}
