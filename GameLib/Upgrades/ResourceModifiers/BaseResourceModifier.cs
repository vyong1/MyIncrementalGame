using GameLib.IncrementingResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLib.Upgrades
{
    public abstract class ResourceModifier
    {
        protected Action<IncrementingResource> ModifierLogic { get; set; }

        protected IncrementingResource Resource { get; set; }

        protected int UpgradeFactor { get; set; }

        public ResourceModifier(IncrementingResource resource, int upgradeFactor, Action<IncrementingResource> modifierLogic)
        {
            ModifierLogic = modifierLogic;
            Resource = resource;
            UpgradeFactor = upgradeFactor;
        }

        public void ApplyLogic()
        {
            if (ModifierLogic != null)
            {
                ModifierLogic.Invoke(Resource);
            }
        }
            
        public abstract override string ToString();
    }
}
