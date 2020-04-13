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

        public Result Resolve()
        {
            result = new Result();
            //first without adding or minus
            if (CheckEquation(x, y, sign, z))
                result.AddEquation(FormatFinalResult(x, y, sign, z));

            var dict = DictionaryTransformationMatchesWithoutMove.Dictionary;
            result.AddEquation(CheckWithThisConfiguration(sign, dict));

            var reverse_sign = this.sign.Reverse();
            var sign_trans_dict = reverse_sign.GetTransformationDictionary();
            result.AddEquation(CheckWithThisConfiguration(reverse_sign, sign_trans_dict));
            return result;
        }

        private List<string> CheckWithThisConfiguration(Sign _sign, Dictionary<int, Numbers> _dict)
        {
            List<string> oResult = new List<string>();
            String sEquation = string.Empty;
            Numbers numbers = new Numbers { x, y, z };
            for (int i = 0; i < numbers.Count; i++)
            {
                sEquation = CheckAllTransformationForNumberPosition(numbers[i], _sign, _dict, i);
                if (!string.IsNullOrEmpty(sEquation))
                    oResult.Add(sEquation);
            }
            return oResult;
        }

        private string CheckAllTransformationForNumberPosition(Number _number, Sign _sign, Dictionary<int, Numbers> _dict, int position)
        {
            Func<Number, bool> f = null;
            Func<Number, string> r = null;
            switch (position)
            {
                case 0:
                    f = new Func<Number, bool>(number => CheckEquation(number, y, _sign, z));
                    r = new Func<Number, string>(number => FormatFinalResult(number, y, _sign, z));
                    break;

                case 1:
                    f = new Func<Number, bool>(number => CheckEquation(x, number, _sign, z));
                    r = new Func<Number, string>(number => FormatFinalResult(x, number, _sign, z));
                    break;

                case 2:
                    f = new Func<Number, bool>(number => CheckEquation(x, y, _sign, number));
                    r = new Func<Number, string>(number => FormatFinalResult(x, y, _sign, number));
                    break;
            }

            foreach (Number number in _dict[_number.Value])
            {
                if (f.Invoke(number))
                    return r.Invoke(number);
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