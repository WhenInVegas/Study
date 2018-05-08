using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Study.Inheritance
{
    public class InheritanceMemberAccess
    {
    }

    class BaseClass
    {
        public void PublicMember()
        {
            Console.WriteLine("I am Public Method");
        }

        protected void ProtectedMember()
        {
            Console.WriteLine("I am Protected Method");
        }

        internal void InternalMember()
        {
            Console.WriteLine("I am Internal Method");
        }

        protected internal void ProtectedInternalMember()
        {
            Console.WriteLine("I am Protected Internal Method");
        }

        private void PrivateMember()
        {
            Console.WriteLine("I am Private Method");
        }
    }

    class ChildClass : BaseClass
    {
        public void CheckMembers()
        {
            PublicMember();
            ProtectedMember();
            ProtectedInternalMember();
            InternalMember();
            //PrivateMember();  // raise error, it can't be accessed
        }
    }
}
