using Observer.InterFace;
using Observer.publisher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.ConcreteObservers
{
    internal class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            if (((Subject)subject).State < 3)
            {
                Console.WriteLine("ConcreteObserverA: Reacted to the event.");
            }
        }
    }
}
