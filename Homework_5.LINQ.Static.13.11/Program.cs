using System;

namespace Homework_5.LINQ.Static._13._11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            Action someAction1 = () => Console.WriteLine("Произвольная фраза в консоли.");
            MyNonStaticClass.MyStaticMethod(someAction1);

            //Task 2
            MyStaticClass.CallDelegate(() => Console.WriteLine("\nЕще одна произвольная фраза."));

            //Task 3
            Human human = new Human();
            Console.WriteLine("\nThe previous most important body part is " + human.MostImportantBodyPart);
            Console.WriteLine("The new most important body part are " + human.Evolve());

            //Task 4
            MyLINQTask.MyLINQMethod();
            Console.Read();
        }
    }
}
