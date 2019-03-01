using GameLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace GameLib.IncrementingResources
{
    public abstract class IncrementingResource : Tickable, INotifyPropertyChanged
    {
        private double _delta;
        public double Delta
        {
            get
            {
                return _delta;
            }
            set
            {
                _delta = value;
                OnPropertyChanged(nameof(Delta));
            }
        }

        private double _value;
        public double Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

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

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
