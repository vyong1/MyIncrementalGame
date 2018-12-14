using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLib.Upgrades
{
    public interface Upgradable
    {
        void ApplyUpgrade(Upgrade upgrade);
    }
}
