using System;

namespace Matches
{
    public class Number
    {
        private int value;

        public int Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public Number(int value)
        {
            this.value = value;
        }

        public Number(string value)
        {
            this.value = int.Parse(value);
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
}