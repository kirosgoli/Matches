using Matches.Operators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Matches
{
    public class Equation
    {
        private Number x;
        private Number y;
        private Sign sign;
        private Number z;

        internal Equation(Number x, Number y, Sign sign, Number z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.sign = sign;
        }

        public string Resolve()
        {
            return FormatFinalResult();
        }

        private string FormatFinalResult()
        {
            string result = string.Empty;
            result = String.Format("{0}{1}{2}={3}",
                x,
                sign,
                y,
                z);
            return result;
        }
    }
}