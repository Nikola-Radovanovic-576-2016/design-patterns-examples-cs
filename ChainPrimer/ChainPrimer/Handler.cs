using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainPrimer
{
    interface Handler
    {
        void Handle(Problem problem);
        void SetNext(Handler handler);
    }
}
