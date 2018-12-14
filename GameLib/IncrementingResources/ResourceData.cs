using GameLib.CoreLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLib.IncrementingResources
{
    public class ResourceData : List<IncrementingResource>, Tickable
    {
        public void Tick()
        {
            foreach (IncrementingResource r in this)
            {
                r.Tick();
            }
        }
    }
}
