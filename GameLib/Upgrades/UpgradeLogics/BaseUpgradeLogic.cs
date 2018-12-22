using GameLib.IncrementingResources;
using GameLib.PlayerLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLib.Upgrades
{
    public abstract class BaseUpgradeLogic
    {
        protected Action<IncrementingResource> Logic { get; set; }

        protected IncrementingResource Resource { get; set; }

        protected int UpgradeFactor { get; set; }

        public BaseUpgradeLogic(IncrementingResource resource, int upgradeFactor, Action<IncrementingResource> logic)
        {
            Logic = logic;
            Resource = resource;
            UpgradeFactor = upgradeFactor;
        }

        public void ApplyLogic()
        {
            if (Logic != null)
            {
                Logic.Invoke(Resource);
            }
        }

        public abstract override string ToString();
    }
}
