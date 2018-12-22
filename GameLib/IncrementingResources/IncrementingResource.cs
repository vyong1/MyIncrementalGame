using GameLib.CoreLib;
using GameLib.Upgrades;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameLib.IncrementingResources
{
    public abstract class IncrementingResource : Tickable
    {
        public double Delta { get; set; }
        public double Value { get; set; }
        public string Name { get; set; }

        public IncrementingResource(double delta, double value, string name)
        {
            Delta = delta;
            Value = value;
            Name = name;
        }

        public void Tick()
        {
            Value = Math.Round(Value + Delta, 2);
        }

        public override string ToString()
        {
            return string.Format("{0} (+{1}/tick) -> Value = {2}", Name, Delta, Value);
        }
    }
}
