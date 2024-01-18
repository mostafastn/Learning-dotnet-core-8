using Observer.InterFace;
using Observer.publisher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.ConcreteObservers
{
    internal class ConcreteObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            if (((Subject)subject).State is 0 or >= 2)
            {
                Console.WriteLine("ConcreteObserverB: Reacted to the event.");
            }
        }
    }
}
