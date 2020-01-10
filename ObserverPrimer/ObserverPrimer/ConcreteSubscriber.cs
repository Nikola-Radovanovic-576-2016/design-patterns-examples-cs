using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPrimer
{
    class ConcreteSubscriber : Subscriber
    {
        public string Name { get; set; }

        public ConcreteSubscriber(string name)
        {
            Name = name;
        }
        public void Update(Publisher publisher)
        {
            Console.WriteLine("Dear, " + Name + ". " + publisher.Name + " has posted a video.");
        }
    }
}
