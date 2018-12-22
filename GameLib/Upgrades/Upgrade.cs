﻿using GameLib.IncrementingResources;
using GameLib.PlayerLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLib.Upgrades.UpgradeLogics
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
    }
}
