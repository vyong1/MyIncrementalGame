using GameLib.IncrementingResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLib.Upgrades.UpgradeLogics
{
    public class DeltaMultUpgradeLogic : BaseUpgradeLogic
    {
        public DeltaMultUpgradeLogic(IncrementingResource resource, int factor)
            : base(resource, factor, r => r.Delta = r.Delta * factor)
        {

        }

        public string ToString()
        {
            return string.Format("Gain x{0} to {1}", UpgradeFactor, Resource.Name);
        }
    }
}
