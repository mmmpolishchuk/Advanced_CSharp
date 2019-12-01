using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10.Atributes.Forms._02._12
{
    public static class DirectoryInfoClass
    {
        public static void CreateDirectoryInfo()
        {
            var creatingDirectory = new DirectoryInfo(@"D:\Directory#1\Directory#2");
            var creatingFileInfo = new FileInfo(@"D:\Directory#1\Directory#2\FileInfo.pdf");

            if (creatingDirectory.Exists && creatingFileInfo.Exists)
            {
                Console.WriteLine("Directories " + creatingDirectory.FullName +
                    " and file " + creatingFileInfo.FullName + " already exist.");
            }
            else if (creatingDirectory.Exists && !creatingFileInfo.Exists)
            {
                creatingFileInfo.Create();
                Console.WriteLine("File " + creatingFileInfo.FullName + " was created.");
            }
            else if (!creatingDirectory.Exists && creatingFileInfo.Exists)
            {
                creatingDirectory.Create();
                Console.WriteLine("Directories " + creatingFileInfo.FullName + " were created.");
            }
            else
            {
                creatingDirectory.Create();
                creatingFileInfo.Create();
                Console.WriteLine("Directories " + creatingDirectory.FullName +
                    " and file " + creatingFileInfo.FullName + " were created.");
            }
        }
        //public static void CreateFileInfo()
        //{
        //    var creatingFileInfo = new FileInfo(@"D:\Directory#1\Directory#2\FileInfo.pdf");

        //    if (!creatingFileInfo.Exists)
        //    {
        //        creatingFileInfo.Create();
        //        Console.WriteLine(creatingFileInfo.FullName + " was created.");
        //    }
        //    else
        //    {
        //        Console.WriteLine(creatingFileInfo.FullName);
        //    }

        //}
    }
}
