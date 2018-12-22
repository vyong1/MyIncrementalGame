using GameLib.IncrementingResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLib.Upgrades.UpgradeLogics
{
    public class ValueAddUpgradeLogic : BaseUpgradeLogic
    {
        public ValueAddUpgradeLogic(IncrementingResource resource, int add)
            : base(resource, add, r => r.Value = r.Value + add)
        {

        }

        public override string ToString()
        {
            return string.Format("Gain {0} {1}", UpgradeFactor, Resource.Name);
        }
    }
}
