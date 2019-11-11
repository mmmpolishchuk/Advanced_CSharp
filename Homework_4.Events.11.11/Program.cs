using System;

namespace Homework_4.Events._11._11
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeClass myClass = new SomeClass();
            myClass.ShowInfo();

            Console.WriteLine();

            SomeSubscriber someSubscriber = new SomeSubscriber();
            someSubscriber.ShowMyEvent();

            Console.WriteLine();
            
            SomeSubscriberSecond someSubscriberSecond = new SomeSubscriberSecond();
            someSubscriberSecond.ShowMySecondEvent();
        }
    }
}
