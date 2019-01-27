using GameLib.IncrementingResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLib.Upgrades
{
    public class Upgrade
    {
        public string Title { get; }
        private ResourceModifier Cost { get; set; }
        private ResourceModifier Benefit { get; set; }

        public Upgrade(ResourceModifier cost, ResourceModifier benefit)
            : this("<Insert Upgrade Title Here>", cost, benefit)
        {
            
        }

        public Upgrade(string title, ResourceModifier cost, ResourceModifier benefit)
        {
            Title = title;
            Cost = cost;
            Benefit = benefit;
        }

        public void Apply()
        {
            Cost.ApplyLogic();
            Benefit.ApplyLogic();
        }

        public override string ToString()
        {
            return string.Format("{0}\n{1}", Cost.ToString(), Benefit.ToString());
        }
    }
}
