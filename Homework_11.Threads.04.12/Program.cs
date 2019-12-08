using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Homework_11.Threads._04._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread secondThread = new Thread(() =>
                       {
                           Console.WriteLine("Second thread\tResult: " + FibonachiClass.Fibonachi(10));
                       });
            secondThread.Start();

            Console.WriteLine("Main thread\tResult: " + FibonachiClass.Fibonachi(10));

            Task_4.AsyncMethod();
            Console.ReadKey();
        }
    }
}
