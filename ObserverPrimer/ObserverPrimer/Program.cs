using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPrimer
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher("Ozbiljne teme");
            ConcreteSubscriber subscriber1 = new ConcreteSubscriber("Nikola");
            ConcreteSubscriber subscriber2 = new ConcreteSubscriber("Pera");
            ConcreteSubscriber subscriber3 = new ConcreteSubscriber("Mare");
            publisher.Subscribe(subscriber1);
            publisher.Subscribe(subscriber2);
            publisher.Subscribe(subscriber3);
            publisher.Notify();
        }
    }
}
