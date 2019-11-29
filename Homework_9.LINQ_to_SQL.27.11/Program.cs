using Homework_10.LINQ_to_SQL._27._11.Director_Manipulating;
using System;
using System.Windows.Forms;

namespace Homework_10.LINQ_to_SQL._27._11
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //Adding_Directors.AddDirct();
            //Deleting_Directors.DeleteDirect();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Directors_Form());
            Console.ReadKey();
        }
    }
}
