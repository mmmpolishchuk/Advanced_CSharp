using System;
using System.Collections.Generic;
using System.Text;

//    Обьявите тип делегата, который не будет ничего возвращать или принимать.
//    Создайте событие на основе этого делегата.
//    Используйте базовый синтаксис для всего этого (т.е.должен быть создан экземпляр делегата, 
//    должен быть метод который будет передан в экземпяр делегата 
//    и потом созданый экземпляр делегата должен подписаться на событие)

namespace Homework_4.Events._11._11
{
    public delegate void DelegateEvent();

    public class SomePublisher
    {
        public event DelegateEvent MyOwnEvent;

        public void MethodInvoker()
        {
            if (MyOwnEvent != null)
            {
                MyOwnEvent.Invoke();
            }
        }
    }
    public class SomeSubscriber
    {
        public void ShowMyEvent()
        {
            SomePublisher somePublisher = new SomePublisher();

            DelegateEvent delegateEvent = new DelegateEvent(SendMassegeHendler);

            somePublisher.MyOwnEvent += delegateEvent;

            somePublisher.MethodInvoker();
        }
        private static void SendMassegeHendler()
        {
            Console.WriteLine("My simple event is invoked.");
        }
    }
}
