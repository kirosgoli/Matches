using System;
using System.Collections.Generic;
using System.Text;

namespace Matches.Dictionaries
{
    public class DictionaryTransformationMatchesAddOne
        : Dictionary<int, Numbers>

    {
        private static DictionaryTransformationMatchesAddOne dictionary;

        public static DictionaryTransformationMatchesAddOne Dictionary
        {
            get
            {
                if (dictionary == null)
                {
                    dictionary = new DictionaryTransformationMatchesAddOne();
                }
                return dictionary;
            }
        }

        private DictionaryTransformationMatchesAddOne()
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
            { eight};
            Add(0, transformation);
            transformation = new Numbers()
            { seven};
            Add(1, transformation);
            Add(2, new Numbers());
            transformation = new Numbers()
            { nine};
            Add(3, transformation);
            Add(4, new Numbers());
            transformation = new Numbers()
            { nine,six};
            Add(5, transformation);
            transformation = new Numbers()
            { eight};
            Add(6, transformation);
            Add(7, new Numbers());
            Add(8, new Numbers());
            transformation = new Numbers()
            { eight};
            Add(9, transformation);
        }
    }
}