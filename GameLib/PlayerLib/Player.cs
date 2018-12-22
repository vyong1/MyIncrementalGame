using GameLib.Upgrades;
using GameLib.Upgrades.UpgradeLogics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLib.PlayerLib
{
    public class Player
    {
        public PlayerResources Resources { get; }

        public List<Upgrade> UpgradesTaken { get; }

        public Player()
        {
            Resources = new PlayerResources();
            UpgradesTaken = new List<Upgrade>();
        }
    }
}
