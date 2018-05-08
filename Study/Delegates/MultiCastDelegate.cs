using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Study.Delegates
{
    class MultiCastDelegate
    {
        public class Operation
        {
            public void Add(int a) => Console.WriteLine("Addition={0}", a + 10);
            public void Square(int a) => Console.WriteLine("Multiple={0}", a * a);

            public void One()
            {
                Console.WriteLine("one display");
                throw  new Exception("error");
            }

            public void Two()
            {
                Console.WriteLine("Two display");
            }
        }

        delegate void Delop2();
        delegate void DelOp(int x); 
        public class Output
        {
            void Main()
            {
                Operation op = new Operation();
                DelOp obj = op.Add;
                obj += op.Square ;

                obj(2);
                obj(8);

                Delop2 op2 = op.One;
                op2 += op.Two;

                Delegate[] del = op2.GetInvocationList();
                foreach (Delop2 d in del)
                {
                    try
                    {
                        d();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("error caught");
                    }
                }

                // one display
                // error caught
                // two display

            }
        }

    }
}
