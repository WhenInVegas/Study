using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Delegates
{
    class AnonymousMethod
    {
        class Program
        {
            delegate void Operation();

            void Main()
            {
                Operation obj = delegate { Console.WriteLine("Anonymous Method"); };
                obj();
                Console.ReadLine();
            }
        }
    }
}
