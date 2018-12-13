using System;
using System.Collections.Generic;
using System.Text;

namespace MyIncrementalGame
{
    public /*abstract*/ class Resource
    {
        public double Delta { get; set; }
        public double Value { get; set; }
        public String Name { get; set; }

        public void Tick()
        {
            Value = Value + Delta;
        }

        public override string ToString()
        {
            return string.Format("{0} -> Value = {1}, Delta = {2}", Name, Value, Delta);
        }
    }
}
