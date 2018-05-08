using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Inheritance
{
    class Abstract
    {
    }

    abstract class AbastractBaseClass
    {
        public int num = 5;
        public abstract void sum();

        public void Double()
        {
            num = num * 2;
        }
    }

    class ChildClass1 : AbastractBaseClass
    {
        public override void sum()
        {
            Console.WriteLine("Totl Sum : " + num * num);
        }

        public void Print()
        {
            Double();
        }
    }
}
