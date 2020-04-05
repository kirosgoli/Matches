using System;
using System.Collections.Generic;
using System.Text;

namespace Matches.Dictionaries
{
    public class DictionaryTransformationMatchesWithoutMove
        : Dictionary<int, Numbers>

    {
        private static DictionaryTransformationMatchesWithoutMove dictionary;

        public static DictionaryTransformationMatchesWithoutMove Dictionary
        {
            get
            {
                if (dictionary == null)
                {
                    dictionary = new DictionaryTransformationMatchesWithoutMove();
                }
                return dictionary;
            }
        }

        private DictionaryTransformationMatchesWithoutMove()
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

            Numbers transformation = new Numbers()
            { nine,six};
            Add(0, transformation);
            Add(1, new Numbers());
            transformation = new Numbers()
            { three};
            Add(2, transformation);
            transformation = new Numbers()
            { two,five};
            Add(3, transformation);
            Add(4, new Numbers());
            transformation = new Numbers()
            { three};
            Add(5, transformation);
            transformation = new Numbers()
            { nine,zero};
            Add(6, transformation);
            Add(7, new Numbers());
            Add(8, new Numbers());
            transformation = new Numbers()
            { zero,six};
            Add(9, transformation);
        }
    }
}