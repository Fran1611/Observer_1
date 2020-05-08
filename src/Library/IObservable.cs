using System.Collections.Generic;

namespace Observer
{
    public interface IObservable
    
    {
        List<IObserver> Observers{get;}
        void Unsubscribe(IObserver observer);
        void Subscribe(IObserver observer);
    }
}