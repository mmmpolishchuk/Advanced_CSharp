using System;

namespace Homework_3.Delegate._04._11
{
    class Program
    {
        static void Main(string[] args)
        {
            BigBadWolf oneWolf = new BigBadWolf("Wolf");
            oneWolf.ShowName();
            Console.WriteLine("===================================================");

            Country.DelegatesCombined();
            
          
        }
    }
}
