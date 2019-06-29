using System;

namespace Observer
{
    class Program
    {

        /// <summary>
        /// The two important key terms in the Observer pattern are the Subject and the Observer.
        /// The Subject is the object which holds the value and takes responsibility in notifying the observers when the value is changed.
        /// The subject could be a database change, property change or so.
        /// 
        /// The main perpose in the Observer pattern is notify the all connected object from subject .
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            Subject subject = new Subject();
            //Observer1 take a subscription to the store
            Observer observer1 = new Observer("Observer 1");
            subject.Subscribe(observer1);

            //Observer2 also subscribes to the store
            subject.Subscribe(new Observer("Observer 2"));
            subject.Inventory++;

            //Observer1 unsubscribes and Observer3 subscribes to notification.
            subject.Unsubscribe(observer1);
            subject.Subscribe(new Observer("Observer 3"));
            subject.Inventory++;
            Console.ReadLine();
        }
    }
}
