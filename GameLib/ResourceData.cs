using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLib
{
    public class ResourceData : List<Resource>, Tickable
    {
        public void Tick()
        {
            foreach (Resource r in this)
            {
                r.Tick();
            }
        }
    }
}
