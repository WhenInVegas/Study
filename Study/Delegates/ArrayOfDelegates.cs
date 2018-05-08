using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Study.Delegates
{
    public class ArrayOfDelegates
    {

        public class Operation
        {
            public void Add(int x, int y)
            {
                int Total = x + y;
                Console.WriteLine("Addition={0}", Total);
            }

            public void Multiple(int x, int y)
            {
                int total = x * y;
                Console.WriteLine("Multiply={0}", total);
            }
        }

        class Output
        {
            delegate void DelOp(int x, int y);
            void Main()
            {
               Operation op = new Operation();
                DelOp[] obj =
                {
                    new DelOp(op.Add),
                    new DelOp(op.Multiple)
                };

                for (int i = 0; i < obj.Length; i++)
                {
                    obj[i](2, 5);
                    obj[i](8, 5);
                    obj[i](4, 6);
                }

                Console.ReadLine();
                // output:
                // Addition=7
                // Addition=13
                // Addition=10
                // Addition=40
                // Addition=24
                //
            }
        }


    }



}
