using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.EncapsulationAndAbstration
{
    public class PublicAccessSpecifiers
    {
        // string variable declared as public
        public string Name;
        // public method
        public void Print()
        {
            Console.WriteLine("\nMy name is " + Name);
            Console.ReadLine();
        }
    }

    public class PublicAccessRunOutput
    {
        public void Run()
        {
            PublicAccessSpecifiers ac = new PublicAccessSpecifiers();
            Console.Write("enter your name:\t");
            // Accepting value in public variable that is outside the class
            ac.Name = Console.ReadLine();
            ac.Print();
        }
    }
}
