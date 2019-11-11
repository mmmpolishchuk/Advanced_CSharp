using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_3.Delegate._04._11
{
    delegate BigBadWolf GetTypeDelegate(string name);
    public class BigBadWolf
    {
        public string name;
        public BigBadWolf(string name)
        {
            this.name = name;
        }
        public void ShowName()
        {
            Console.WriteLine(name);
        }
    }
    public class WolfDelegate
    {
        //екземпляр делегата в анонімному методі
        //GetTypeDelegate wolfType = delegate (string name)
        //{
        //    return new BigBadWolf(name);       //повернення значення типу класу BigBadWolf
        //};

        GetTypeDelegate wolfType = name => new BigBadWolf(name); // використання лямбда-виразу

        public void WolfInfo(string name)
        {
            var wolf = wolfType(name); // створюємо екземпляр класу BigBadWolf
            wolf.ShowName();
        }
    }

}


