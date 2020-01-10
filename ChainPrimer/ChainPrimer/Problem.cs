using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainPrimer
{
    class Problem
    {
        public enum ProblemType { EZ, MEDIUM, HARD};
        public string Name { get; set; }
        public ProblemType Type { get; set; }

        public Problem(string name, ProblemType type)
        {
            Name = name;
            Type = type;
        }
    }
}
