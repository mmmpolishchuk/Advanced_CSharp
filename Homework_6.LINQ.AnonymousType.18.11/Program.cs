using System;

namespace Homework_6.LINQ.AnonymousType._18._11
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassWithAnonType classWithAnonType = new ClassWithAnonType();
            classWithAnonType.MyAnonymousType();
            Console.WriteLine();
            ClassWithAnonTypeTwo classWithAnonTypeTwo = new ClassWithAnonTypeTwo();
            classWithAnonTypeTwo.AnonymousTypeMethod();
        }
    }
}
