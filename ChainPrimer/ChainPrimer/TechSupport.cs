using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainPrimer
{
    class TechSupport : Handler
    {
        private Handler _next;

        public void Handle(Problem problem)
        {
            if (problem.Type == Problem.ProblemType.MEDIUM)
                Console.WriteLine("Problem resen od strane tehnicke podrske");
            else if (_next != null)
                _next.Handle(problem);
            else
                Console.WriteLine("Problem neresiv");
        }

        public void SetNext(Handler handler)
        {
            _next = handler;
        }
    }
}
