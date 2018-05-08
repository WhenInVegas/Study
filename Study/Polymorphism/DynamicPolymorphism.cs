using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Polymorphism
{
    class DynamicPolymorphism
    {
        class Program
        {
            void Output()
            {
                Chocolate ch = new Chocolate();
                ch.Flavor();
                Console.ReadKey();
            }

            // Class: Icecream
            // Class: Chocolate
            // IceCream Type : Chocolate
        }

        class IceCream
        {
            public IceCream()
            {
                Console.WriteLine("Class : Icecream");
            }

            public virtual void Flavor()
            {
                Console.WriteLine("IceCream Type : Vanilla");
            }
        }

        class Chocolate : IceCream
        {
            public Chocolate()
            {
                Console.WriteLine("Class : Chocolate");
            }

            public override void Flavor()
            {
                Console.WriteLine("IceCream Type: Chocolate");
            }
        }

    }
}
