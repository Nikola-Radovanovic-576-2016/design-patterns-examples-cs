using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPrimer
{
    class Publisher
    {
        public string Name;
        private List<Subscriber> _subscribers;

        public Publisher(string name)
        {
            Name = name;
            _subscribers = new List<Subscriber>();
        }
        public void Subscribe(Subscriber s)
        {
            _subscribers.Add(s);
        }
        public void Unsubscribe(Subscriber s)
        {
            _subscribers.Remove(s);
        }
        public void Notify()
        {
            foreach (Subscriber s in _subscribers)
                s.Update(this);
        }
    }
}
