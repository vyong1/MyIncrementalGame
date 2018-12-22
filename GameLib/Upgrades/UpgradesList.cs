using GameLib.PlayerLib;
using GameLib.Upgrades.UpgradeLogics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLib.Upgrades
{
    public class UpgradesList : List<Upgrade>
    {
        public UpgradesList(Player p)
        {
            GenerateUpgradesList(p);
        }

        private void GenerateUpgradesList(Player p)
        {
            Add(new Upgrade(
                   new DeltaMultUpgradeLogic(p.Resources.Corn, 2),
                   new DeltaMultUpgradeLogic(p.Resources.Wheat, 4)
                ));

            Add(new Upgrade(
                   new DeltaMultUpgradeLogic(p.Resources.Corn, 1),
                   new DeltaMultUpgradeLogic(p.Resources.Wheat, 2)
                ));

            Add(new Upgrade(
                   new DeltaMultUpgradeLogic(p.Resources.Corn, 23),
                   new DeltaMultUpgradeLogic(p.Resources.Wheat, 4)
                ));

            Add(new Upgrade(
                   new DeltaMultUpgradeLogic(p.Resources.Corn, 5),
                   new DeltaMultUpgradeLogic(p.Resources.Wheat, 2)
                ));
        }
    }
}
