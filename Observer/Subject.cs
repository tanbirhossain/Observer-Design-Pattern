using System.Collections.Generic;

namespace Observer
{
    interface ISubject
    {
        void Subscribe(Observer observer);
        void Unsubscribe(Observer observer);
        void Notify();
    }
    class Subject : ISubject
    {
        private List<Observer> observers = new List<Observer>();
        private int _int;
        public int Inventory
        {
            get { return _int; }
            set
            {
                if (value > _int)
                {
                    Notify();
                }
                _int = value;
            }
        }
        public void Subscribe(Observer observer)
        {
            observers.Add(observer);
        }
        public void Unsubscribe(Observer observer)
        {
            observers.Remove(observer);
        }
        public void Notify()
        {
            observers.ForEach(x => x.Update());
        }
    }
}
