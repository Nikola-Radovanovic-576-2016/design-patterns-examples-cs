using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPrimer
{
    class CareTaker
    {
        private Originator _originator;
        private List<Originator.Memento> _history;

        public CareTaker(Originator originator)
        {
            _originator = originator;
            _history = new List<Originator.Memento>();
        }
        public void undo()
        {
            Originator.Memento m = _history.Last();
            _history.Remove(m);
            _originator.restore(m);
        }
        public void save()
        {
            Originator.Memento m = _originator.save();
            _history.Add(m);
        }
    }
}
