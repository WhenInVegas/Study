using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Encapsulation: to hide its members from outside class or interface
// 5 types of Access Specifier to encapsulate data: on variable or function
// 1. public:  ------ public member can be accessd from anywhere even outside the namespace
// 2. private: ------ restrict the member variable or funciton to be called outside from the parent class; 
//             ------ can store or retrieve value form private access using get set property
// 3. internal: ----- hides its member variables and methods form other classess and objects, that is resides in other namespaces
//             ------ The variable or classes that are declared with internal can be access by any member within application. It is the default access specifiers for a class in C# programming.
// 4. protected: ---- hides its member variables and funtions from other classess and objects; can only be access in child class; 
//             ------ becomes very important while implementing inheritance
// 5. protectected internal: ----- The protected internal access specifier allows its members to be accessed in derived class,
//                           ----- containing class or classes within same application.
//                           ----- However, this access specifier rarely used in C# programming but it becomes important while implementing inheritance.

// Abstration: to show only essential features


namespace Study.EncapsulationAndAbstration
{
   public class Example
    {

        public static void RunExample()
        {
            PublicAccessRunOutput run = new PublicAccessRunOutput();
            run.Run();

            PrivateAccessSpecifiersOutput runPrivateAccessSpecifiers = new PrivateAccessSpecifiersOutput();
            runPrivateAccessSpecifiers.Run();
        }
        
    }
}
