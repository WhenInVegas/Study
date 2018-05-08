using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.EncapsulationAndAbstration
{
    public class PrivateAccessSpecifiers
    {
        // string variable declared as private
        private string _name;

        public void Print() // public method
        {
            Console.WriteLine("\nMy name is " + _name);
        }
    }

    public class PrivateAccessSpecifiersOutput
    {
        public void Run()
        {
            PrivateAccessSpecifiers ac = new PrivateAccessSpecifiers();
            Console.Write("Enter your name: \t");
            // raise error because of its protection level
            // ac.name = Console.ReadLine();
            ac.Print();
            Console.ReadLine();
        }
    }
}
