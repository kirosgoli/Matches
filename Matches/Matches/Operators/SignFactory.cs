using System;
using System.Collections.Generic;
using System.Text;

namespace Matches.Operators
{
    public class SignFactory
    {
        public static Sign GetSign(string symbol)
        {
            Sign sign = null;
            switch (symbol)
            {
                case "+":
                    sign = new Plus();
                    break;

                case "-":
                    sign = new Minus();
                    break;

                default:
                    break;
            }
            return sign;
        }
    }
}