using GameLib.IncrementingResources;
using GameLib.PlayerLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLib.Upgrades
{
    public class Upgrade
    {
        private BaseUpgradeLogic Cost { get; set; }
        private BaseUpgradeLogic Benefit { get; set; }

        public Upgrade(BaseUpgradeLogic cost, BaseUpgradeLogic benefit)
        {
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
