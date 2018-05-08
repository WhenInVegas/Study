using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Generics: type of classes which has PlaceHolder instead of datatypes.
// --- when you create generic classes you don't specify its data type;
// --- datatypes are defined when you create objects;
// --- generic classes: resusable adn type-safe and your classes and
// --- methods are able to work with any datatypes
// --- Generics improves code usability, type safety and performance.
// --- Mostly Generics are used for creating collection classes.
// --- You can use Generics by adding System.Collections.Generic namespace.
// --- You can create your own Generic interfaces, classes, methods, events and delegates.

namespace Study.Generics
{
    class Generics
    {
        class Program
        {
            void Output()
            {
                Console.WriteLine("Printing Integer Value");
                GenClass<int> gen = new GenClass<int>();
                gen.GenMethod(144);

                Console.WriteLine("Printing String Value");
                GenClass<string> genstring = new GenClass<string>();
                genstring.GenMethod("Hello string");

                // Printing Integer Value
                // 144
                // Printing String Value
                // Hello String
            }


            private class GenClass<T>
            {
                protected int m_value;
                public void GenMethod(T printValue)
                {
                    Console.WriteLine(printValue.ToString());
                }
            }


        }
    }
}
