using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Aspects.Advices;
using PostSharp.Patterns.Model;

namespace Study.Delegates
{
    public class Exmple
    {

    }

   
    public class NumberReachedEventArgs : EventArgs
    {
        private int _reached;

        public NumberReachedEventArgs(int num)
        {
            this._reached = num;
        }

        public int ReachedNumber
        {
            get { return _reached; }
        }

    }

    public delegate void NumberREachedEventHandler(object sender, NumberReachedEventArgs e);

    public class Counter
    {
        public event NumberREachedEventHandler NumberReached;

        public Counter()
        {

        }

        public void CountTo(int countTo, int reachableNum)
        {
            if (countTo < reachableNum)
            {
                throw new ArgumentException("reachbleNum should be less than countTo");
            }

            for (int ctr = 0; ctr <= countTo; ctr++)
            {
                if (ctr == reachableNum)
                {
                    NumberReachedEventArgs e = new NumberReachedEventArgs(reachableNum);
                    OnNumberReached(e);
                    return;
                }
            }
        }

        protected virtual void OnNumberReached(NumberReachedEventArgs e)
        {
            if (NumberReached != null)
            {
                NumberReached(this, e);
            }
        }

    }

}
