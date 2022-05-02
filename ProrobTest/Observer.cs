using System;
using System.Collections.Generic;

namespace ProrobTest
{
    public interface IObserver
    {
        void Update(Observable observable);
    }

    public abstract class Observable
    {
        private List<IObserver> observers = new List<IObserver>();

        public void Add(ref IObserver observer)
        {
            observers.Add(observer);
        }

        public void Remove(ref IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers(int e)
        {
            for (var i = 0; i < observers.Count; i++)
            {
                observers[i].Update(this);
            }
        }
    }
}

