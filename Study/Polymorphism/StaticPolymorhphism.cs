using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

// Static Polymorphism or Compile Time Polymorphism: earling binding or method overloading
// ---- method takes various parameter signature
// Dynamic Polymorphism or Runtime Polymorphism: late binding or method overriding
// ---- overriding a base class method using virtual or override keyword;
// ---- Method overriding means having two or more methods with same name,
// ---- same signature but different implementation

namespace Study.Polymorphism
{
    class StaticPolymorhphism
    {
        class Program
        {
            void Output()
            {
                Calculator cal = new Calculator();
                cal.Sum();
                cal.Sum("Hello");
                cal.Sum(1,2);
                cal.Sum(1.1,1.2);
                cal.Sum(1.10,1.20);


            }
        }

        class Calculator
        {
            public void Sum()
            {
            }

            public void Sum(int x, int y)
            {
            }

            public void Sum(double x, double y)
            {
            }

            public void Sum(float x, float y)
            {
            }

            public void Sum(string s)
            {
            }
        }
    }
}
