using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPrimer
{
    public class Originator
    {
        private string _state;
        
        public Originator(string state)
        {
            _state = state;
        }
        public void setState(string state)
        {
            _state = state;
        }
        public string getState()
        {
            return _state;
        }
        public Memento save()
        {
            return new Memento(_state);
        }
        public void restore(Memento m)
        {
            _state = m.GetState();
        }
        public class Memento
        {
            private string _state;

            public Memento(string state)
            {
                _state = state;
            }
            public string GetState()
            {
                return _state;
            }
        }

    }

}
