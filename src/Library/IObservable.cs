using System.Collections.Generic;

namespace Observer
{
    public interface IObservable
    
    {
        void Unsubscribe(IObserver observer);
        void Subscribe(IObserver observer);
    }
}