using System;
using System.Collections.Generic;
using System.Text;

namespace GameLib
{
    public abstract class Resource
    {
        protected double Delta { get; set; }
        protected double Value { get; set; }
        protected string Name { get; set; }

        public Resource(double delta, double value, string name)
        {
            Delta = delta;
            Value = value;
            Name = name;
        }

        public void Tick()
        {
            Value = Value + Delta;
        }

        public override string ToString()
        {
            return string.Format("{0} (+{1}/tick) -> Value = {2}", Name, Delta, Value);
        }
    }
}
