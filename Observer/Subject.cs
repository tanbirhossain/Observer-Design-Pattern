using System.Collections.Generic;

namespace Observer
{
    interface ISubject
    {
        void Subscribe(IObserver observer);
        void Unsubscribe(IObserver observer);
        void Notify();
    }
    class Subject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private int _int;
        public int Inventory
        {
            get { return _int; }
            set
            {

                Notify();
                _int = value;
            }
        }
        public void Subscribe(IObserver observer)
        {
            observers.Add(observer);
        }
        public void Unsubscribe(IObserver observer)
        {
            observers.Remove(observer);
        }
        public void Notify()
        {
            observers.ForEach(x => x.Update());
        }
    }
}
