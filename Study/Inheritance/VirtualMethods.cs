using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Inheritance
{
    class VirtualMethods
    {

        class BaseClass
        {
            public virtual void Message()
            {
                Console.WriteLine("I am base class Virtual Method");
            }
        }

        class Child1 : BaseClass
        {
            public override void Message()
            {
                Console.WriteLine("I am a child 1 class");
            }
        }

        class  Child2 : BaseClass
        {
            // I have option not to overrid void Message();
        }

    }

}
