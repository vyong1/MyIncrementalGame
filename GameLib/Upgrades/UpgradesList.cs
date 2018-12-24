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
                    "Corn Harvest",
                    new ValueMultModifier(p.Resources.Corn, 0),
                    new DeltaMultModifier(p.Resources.Corn, 4)
                ));
        }
    }
}
