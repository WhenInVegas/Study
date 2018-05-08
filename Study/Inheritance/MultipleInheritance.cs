using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Inheritance
{
    public class MultipleInheritance
    {
    }

    public interface Ibase1
    {
        int MyNumber1 { get; set; }

        void Message();
        void Message1();
    }

    public interface Ibase2
    {
        int MyNumber2 { get; set; }
        void Message();
        void Message2();
    }

    public class Child : Ibase1, Ibase2
    {
        public int MyNumber1 { get; set; }
        void Ibase1.Message()
        {
            throw new NotImplementedException();
        }

        public void Message1()
        {
            throw new NotImplementedException();
        }

        public int MyNumber2 { get; set; }
        void Ibase2.Message()
        {
            throw new NotImplementedException();
        }

        public void Message2()
        {
            throw new NotImplementedException();
        }
    }
}
