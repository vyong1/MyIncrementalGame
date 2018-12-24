using GameLib.IncrementingResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLib.Upgrades.UpgradeLogics
{
    public class ValueMultModifier : ResourceModifier
    {
        public ValueMultModifier(IncrementingResource resource, int factor)
            : base(resource, factor, r => r.Value = r.Value * factor)
        {

        }

        public override string ToString()
        {
            if (UpgradeFactor == 0)
            {
                return string.Format("Lose all {0}", Resource.Name);
            }
            else
            {
                return string.Format("Gain x{0} to {1}", UpgradeFactor * -1, Resource.Name);
            }
        }
    }
}
