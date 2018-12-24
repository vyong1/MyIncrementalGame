using GameLib.IncrementingResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLib.Upgrades.UpgradeLogics
{
    public class DeltaMultModifier : ResourceModifier
    {
        public DeltaMultModifier(IncrementingResource resource, int factor)
            : base(resource, factor, r => r.Delta = r.Delta * factor)
        {

        }

        public override string ToString()
        {
            return string.Format("Gain x{0} to {1} growth", UpgradeFactor, Resource.Name);
        }
    }
}
