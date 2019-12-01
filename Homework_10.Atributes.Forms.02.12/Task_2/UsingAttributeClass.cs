using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10.Atributes.Forms._02._12
{
    public class UsingAttributeClass
    {
        public int price;
        public int Discount { get; set; }

        [AttributeClass("Calculating Black Friday price")]
        private int Calculating()
        {
            return price * Discount / 100;
        }

        [AttributeClass(Line = "Setting new price")]
        public void CalculatingTwo()
        {
            Console.WriteLine("Discount is invalid.");
        }
    }
}
