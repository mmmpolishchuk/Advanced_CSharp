using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Homework_11.Threads._04._12
{
    public static class Task_4
    {
        public static void AsyncMethod()
        {
            Action myDelegate = new Action(CreateText);

            myDelegate.BeginInvoke(null, null);

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(50);
                Console.Write("*");
            }
        }
        private static void CreateText()
        {
            var file = new FileInfo(@"D:\Homework\Text.txt");

            using (StreamWriter writer = file.CreateText())
            {
                writer.WriteLine("Simple text".ToUpper());
                Console.WriteLine("Text is written to the file");
            }
        }
    }
}
