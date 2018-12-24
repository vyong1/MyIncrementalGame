using GameLib.IncrementingResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLib.Upgrades.UpgradeLogics
{
    public class ValueAddSubModifier : ResourceModifier
    {
        public ValueAddSubModifier(IncrementingResource resource, int add)
            : base(resource, add, r => r.Value = r.Value + add)
        {

        }

        public override string ToString()
        {
            if(UpgradeFactor < 0)
            {
                return string.Format("Lose {0} {1}", UpgradeFactor * -1, Resource.Name);
            }
            else
            {
                return string.Format("Gain {0} {1}", UpgradeFactor, Resource.Name);
            }
        }
    }
}
