using System;
using System.Collections.Generic;
using System.Text;

namespace Matches.Operators
{
    public class Minus : Sign
    {
        internal override int GetSign()
        {
            return -1;
        }

        public override string ToString()
        {
            return "-";
        }
    }
}