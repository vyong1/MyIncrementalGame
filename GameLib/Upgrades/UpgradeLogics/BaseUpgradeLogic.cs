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
        private Action<IncrementingResource> Logic { get; set; }

        private IncrementingResource Resource { get; set; }

        public BaseUpgradeLogic(IncrementingResource resource, Action<IncrementingResource> logic)
        {
            Logic = logic;
            Resource = resource;
        }

        public void ApplyLogic()
        {
            Logic.Invoke(Resource);
        }
    }
}
