using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLib.IncrementingResources
{
    public class Wheat : IncrementingResource
    {
        public Wheat() :
            base(
                delta:  10,
                value:  0,
                name:   "Wheat"
            )
        {

        }
    }
}
