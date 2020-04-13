using Matches.Dictionaries;
using System;
using System.Collections.Generic;
using System.Text;

namespace Matches.Operators
{
    public class Plus : Sign
    {
        internal override int GetSign()
        {
            return 1;
        }

        public override string ToString()
        {
            return "+";
        }

        internal override Sign Reverse()
        {
            return SignFactory.GetSign("-");
        }

        internal override Dictionary<int, Numbers> GetTransformationDictionary()
        {
            return DictionaryTransformationMatchesMinusOne.Dictionary;
        }
    }
}