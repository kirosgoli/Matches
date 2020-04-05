using Matches.Dictionaries;
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
            //first without adding or minus
            if (sign.Calculate(x, y) == z.Value)
                return FormatFinalResult(x, y, sign, z);
            var dict = DictionaryTransformationMatchesWithoutMove.Dictionary;
            foreach (var x1 in dict[x.Value])
            {
                if (sign.Calculate(x1, y) == z.Value)
                    return FormatFinalResult(x1, y, sign, z);
            }

            foreach (var y1 in dict[y.Value])
            {
                if (sign.Calculate(x, y1) == z.Value)
                    return FormatFinalResult(x, y1, sign, z);
            }

            foreach (var z1 in dict[z.Value])
            {
                if (sign.Calculate(x, y) == z1.Value)
                    return FormatFinalResult(x, y, sign, z1);
            }

            return string.Empty;
        }

        private string FormatFinalResult(Number _x, Number _y, Sign _sign, Number _z)
        {
            string result = string.Empty;
            result = String.Format("{0}{1}{2}={3}",
                _x,
                _sign,
                _y,
                _z);
            return result;
        }
    }
}