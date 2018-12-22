using GameLib.IncrementingResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLib.Upgrades.UpgradeLogics
{
    public class ValueSubUpgradeLogic : BaseUpgradeLogic
    {
        public ValueSubUpgradeLogic(IncrementingResource resource, int sub)
            : base(resource, r => r.Value = r.Value - sub)
        {

        }
    }
}
