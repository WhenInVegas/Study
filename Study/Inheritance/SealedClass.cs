using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Inheritance
{
    class SealedClass
    {
        class Program_Output
        {

        }

        public sealed class SealledClass
        {
            public void Message()
            {
                Console.WriteLine("Hey, I am Sealed Class");
            }
        }

        // public class child : SealedClass
        // {
        //      message();
        // }


    }
}
