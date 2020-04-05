using System;
using System.Collections.Generic;
using System.Text;

namespace Matches.Dictionaries
{
    public class DictionaryTransformationMatchesMinusOne
        : Dictionary<int, Numbers>

    {
        private static DictionaryTransformationMatchesMinusOne dictionary;

        public static DictionaryTransformationMatchesMinusOne Dictionary
        {
            get
            {
                if (dictionary == null)
                {
                    dictionary = new DictionaryTransformationMatchesMinusOne();
                }
                return dictionary;
            }
        }

        private DictionaryTransformationMatchesMinusOne()
        {
            ReadConfiguration();
        }

        private void ReadConfiguration()
        {
            Number zero = new Number(0);
            Number one = new Number(1);
            Number two = new Number(2);
            Number three = new Number(3);
            Number four = new Number(4);
            Number five = new Number(5);
            Number six = new Number(6);
            Number seven = new Number(7);
            Number eight = new Number(8);
            Number nine = new Number(9);

            Add(0, new Numbers());
            Add(1, new Numbers());
            Add(2, new Numbers());
            Add(3, new Numbers());
            Add(4, new Numbers());
            Add(5, new Numbers());
            Add(6, new Numbers()
            {
                five
            });
            Add(7, new Numbers()
            {
                one
            });
            Add(8, new Numbers()
            {
                zero,nine,six
            });
            Add(9, new Numbers()
            {
                three,five
            });
        }
    }
}