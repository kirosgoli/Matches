using System;
using System.Collections.Generic;
using System.Text;

namespace Matches.Operators
{
    public abstract class Sign
    {
        public int Calculate(Number x, Number y)
        {
            int result;
            result = x.Value + (GetSign()) * y.Value;
            return result;
        }

        internal abstract int GetSign();
    }
}