using System;
using System.Collections.Generic;
using System.Text;

//Создайте свой НЕстатический класс, в котором будет всего один статический метод который будет
//  принимать делегат Action.
//  Вызовите созданый вами метод и передайте в него экземпялр делегата Action, 
//  пусть этот экземпляр ссылается на метод, который выводит произвольную фразу в консоль.
//  В вашем статическом методе вызовите экземпляр делегата, который вы передали.

namespace Homework_5.LINQ.Static._13._11
{
    public delegate void Action();
    public class MyNonStaticClass
    {
        public static void MyStaticMethod(Action someAction)
        {
            someAction();
        }
    }

}

