using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLib.IncrementingResources
{
    public class WheatResource : IncrementingResource
    {
        public WheatResource() :
            base(
                delta:  10,
                value:  0,
                name:   "Wheat"
            )
        {

        }
    }
}
