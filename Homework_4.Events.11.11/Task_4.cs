using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_4.Events._11._11
{
    public delegate void ImprovedDelegateEvent();
    public class SomePublisherFirst
    {
        public event ImprovedDelegateEvent MyOwnEvent;
        public void MethodInvoker()
        {
            MyOwnEvent?.Invoke();
        }
    }
    public class SomeSubscriberSecond
    {
        public void ShowMySecondEvent()
        {
            SomePublisherFirst somePublisher = new SomePublisherFirst();

            somePublisher.MyOwnEvent += () => Console.WriteLine("My improved event is invoked.");

            somePublisher.MethodInvoker();
        }
    }
}
