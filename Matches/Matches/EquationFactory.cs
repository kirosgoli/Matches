using Matches.Operators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Matches
{
    public static class EquationFactory
    {
        public static Equation GetEquation(string text)
        {
            Equation oResult = null;
            //Walidacja
            if (string.IsNullOrEmpty(text))
                return oResult;
            if (text.Length != 5)
                return oResult;

            Number x = new Number(text[0].ToString());
            Sign sign = SignFactory.GetSign(text[1].ToString());
            Number y = new Number(text[2].ToString());
            Number z = new Number(text[4].ToString());

            oResult = new Equation(x, y, sign, z);

            return oResult;
        }
    }
}