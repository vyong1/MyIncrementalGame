using System;
using System.Collections.Generic;
using System.Text;

namespace GameLib
{
    public abstract class Resource : Upgradable
    {
        public double Delta { get; set; }
        public double Value { get; set; }
        public string Name { get; set; }

        public Resource(double delta, double value, string name)
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

        public void ApplyUpgrade(Upgrade upgrade)
        {
            upgrade.ApplyTo(this);
        }
    }
}
