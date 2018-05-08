using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// delegates: where you want to pass methods around to other methods;


namespace Study.Delegates
{
    public delegate int Operation(int x, int y);

    public class Example2
    {
        int Addition(int a, int b) => a + b;

        int Subtract(int a, int b)
        {
            return a - b;
        }

        void Output()
        {
            Operation obj = new Operation(Addition);
            obj(1, 2);
            // 3
        }
    }
}
