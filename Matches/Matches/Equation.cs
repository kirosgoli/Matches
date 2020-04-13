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
        private Result result;

        internal Equation(Number x, Number y, Sign sign, Number z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.sign = sign;
        }

        public string Resolve()
        {
            result = new Result();
            //first without adding or minus
            if (CheckEquation(x, y, sign, z))
                return FormatFinalResult(x, y, sign, z);

            var dict = DictionaryTransformationMatchesWithoutMove.Dictionary;
            String sResult = CheckWithThisConfiguration(sign, dict);
            if (!string.IsNullOrEmpty(sResult))
                return sResult;

            var reverse_sign = this.sign.Reverse();
            var sign_trans_dict = reverse_sign.GetTransformationDictionary();
            sResult = CheckWithThisConfiguration(reverse_sign, sign_trans_dict);
            return sResult;
        }

        private string CheckWithThisConfiguration(Sign _sign, Dictionary<int, Numbers> _dict)
        {
            string sResult = string.Empty;
            Numbers numbers = new Numbers { x, y, z };
            for (int i = 0; i < numbers.Count; i++)
            {
                sResult = CheckAllTransformationForNumberPosition(numbers[i], _sign, _dict, i);
                if (!string.IsNullOrEmpty(sResult))
                    return sResult;
            }
            return sResult;
        }

        private string CheckAllTransformationForNumberPosition(Number _number, Sign _sign, Dictionary<int, Numbers> _dict, int position)
        {
            foreach (Number number in _dict[_number.Value])
            {
                switch (position)
                {
                    case 0:
                        if (CheckEquation(number, y, _sign, z))
                            return FormatFinalResult(number, y, _sign, z);
                        break;

                    case 1:
                        if (CheckEquation(x, number, _sign, z))
                            return FormatFinalResult(x, number, _sign, z);
                        break;

                    case 2:
                        if (CheckEquation(x, y, _sign, number))
                            return FormatFinalResult(x, y, _sign, number);
                        break;
                }
            }
            return string.Empty;
        }

        private bool CheckEquation(Number _x, Number _y, Sign _sign, Number _z)
        {
            return (_sign.Calculate(_x, _y) == _z.Value);
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