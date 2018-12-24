using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLib.Upgrades.UpgradeLogics
{
    /// <summary>
    /// Upgrade Logic that doesn't do anything
    /// </summary>
    public class NullModifier : ResourceModifier
    {
        public NullModifier()
            : base(null, 0, null)
        {

        }

        public override string ToString()
        {
            return string.Empty;
        }
    }
}
