using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10.Atributes.Forms._02._12
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class AttributeClass : Attribute
    {
        public string Line { get; set; }
        

        public AttributeClass()
        {
        }
        public AttributeClass(string line )
        {
            Line = line;
        }
    }
}
