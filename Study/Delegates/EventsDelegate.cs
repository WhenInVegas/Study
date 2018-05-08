using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Delegates
{
    public delegate void DelEventHandler();

    class EventsDelegate
    {
        public event DelEventHandler Add;

        void Main()
        {
            Add += new DelEventHandler(USA);
        }

        void USA()
        {
            Console.WriteLine("USA");
        }

    }
}
