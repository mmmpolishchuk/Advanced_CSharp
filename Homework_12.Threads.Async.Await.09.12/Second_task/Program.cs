using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_task
{
    class Program
    {
        static void Main(string[] args)
        {
            //SerializeClass.SerializeMethod();
            SerializeClass serializeClass = new SerializeClass();
            serializeClass.DeserializeMethod();
            
            Console.ReadKey();
        }
    }
}
