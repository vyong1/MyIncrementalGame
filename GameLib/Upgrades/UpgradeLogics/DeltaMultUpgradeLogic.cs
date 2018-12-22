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
            : base(resource, r => r.Delta = r.Delta * factor)
        {

        }
    }
}
