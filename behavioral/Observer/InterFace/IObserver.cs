using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace Observer.InterFace
{
    public interface IObserver
    {
        // Receive update from subject
        void Update(ISubject subject);
    }
}
