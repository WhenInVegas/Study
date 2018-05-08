using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Inheritance
{
    class Constructor
    {
        class Program_Output
        {
            static void MainRun(string[] args)
            {
                childclass ch = new childclass();
                childclass ch1 = new childclass("Hello Constructor");
                Console.ReadKey();

                // I am Default Constructors
                // Constructor Message: Hello Constructor
            }
        }


        class baseclass
        {
            public baseclass()
            {
                Console.WriteLine("I am Default Constructors");
            }
            public baseclass(string message)
            {
                Console.WriteLine("Constructor Message : " + message);
            }
        }

        class childclass : baseclass
        {
            public childclass()
            {
            }
            public childclass(string message)
                : base(message)
            {
            }
        }
    }
}
