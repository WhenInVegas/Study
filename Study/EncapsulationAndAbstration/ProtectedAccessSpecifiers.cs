using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.EncapsulationAndAbstration
{
    public class ProtectedAccessSpecifiers
    {
        // string variable declared as protected
        protected string name;

        public void Print()
        {
            Console.WriteLine("\nMy name is " + name);
        }
    }

    public class ProtectedAccessSpecifiers_Output
    {
        public void Run()
        {
            ProtectedAccessSpecifiers ac = new ProtectedAccessSpecifiers();
            Console.Write("Enter your name:\t");
            // IRaiseItemChangedEvents error because of its protection level
            //ac.name = Console.ReadLine();
            ac.Print();
            Console.ReadLine();
        }
    }
}
