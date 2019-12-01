using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10.Atributes.Forms._02._12
{
    class Program
    {
        static void Main(string[] args)
        {
            //DirectoryInfoClass.CreateDirectoryInfo();
            //DirectoryInfoClass.CreateFileInfo();


            UsingAttributeClass attributeClassOne = new UsingAttributeClass();

            //var methodsWithAttribute = attributeClassOne.GetType().GetMethods();
            //foreach (var methodWithAttribute in methodsWithAttribute)
            //    foreach (var attributeData in methodWithAttribute.CustomAttributes)
            //    {
            //        Console.WriteLine(attributeData);
            //    }

            Console.ReadKey();
        }
    }
}
