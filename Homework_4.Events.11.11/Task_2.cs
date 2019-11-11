using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_4.Events._11._11
{
    public delegate T MyGenericDelegate<T>(T parameter);
    class SomeClass
    {
        public void ShowInfo()
        {
            MyGenericDelegate<int> intDelegate;
            intDelegate = x => x * 89;
            Console.WriteLine(intDelegate(8));

            MyGenericDelegate<string> stringDelegate;
            stringDelegate = a => a + "-" + a;
            Console.WriteLine(stringDelegate("Bye"));

            MyGenericDelegate<double> doubleDelegate;
            doubleDelegate = y => y * 3.14;
            Console.WriteLine(doubleDelegate(5.19));
        }
    }
}
