using GameLib.IncrementingResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLib.Upgrades
{
    public class UpgradeClause
    {
        private Action<IncrementingResource> Action { get; set; }

        public UpgradeClause(Action<IncrementingResource> action)
        {
            Action = action;
        }

        public void ExecuteOn(IncrementingResource resource)
        {
            Action.Invoke(resource);
        }
    }
}
