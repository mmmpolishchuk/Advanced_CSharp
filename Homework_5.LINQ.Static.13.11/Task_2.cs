using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5.LINQ.Static._13._11
{
    public delegate void MyDelegate();
        
    public static class MyStaticClass
    {
        public static void CallDelegate(MyDelegate myDelegate)
        {
            myDelegate();
        }

    }
}
