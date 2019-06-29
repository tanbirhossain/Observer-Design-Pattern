using System;

namespace Observer
{
    class Program
    {
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
