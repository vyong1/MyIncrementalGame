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
            : base(resource, r => r.Value = r.Value + add)
        {

        }
    }
}
