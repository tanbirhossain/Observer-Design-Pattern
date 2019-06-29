﻿using System;

namespace Observer
{
    public interface IObserver
    {
        void Update();
    }
    public class Observer : IObserver
    {
        public string ObserverName { get; private set; }
        public Observer(string name)
        {
            this.ObserverName = name;
        }
        public void Update()
        {
            Console.WriteLine("{0}: A new product has arrived at the store", this.ObserverName);
        }
    }
}
