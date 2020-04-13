using System;
using System.Collections.Generic;
using System.Text;

namespace Matches
{
    public class Result
    {
        public bool Ok
        {
            get
            {
                return (equations.Count > 0);
            }
        }

        private List<string> equations;

        public List<string> Equations
        {
            get { return equations; }
        }

        internal Result()
        {
            equations = new List<string>();
        }

        internal void AddEquation(string _equation)
        {
            if (!equations.Contains(_equation))
                equations.Add(_equation);
        }
    }
}