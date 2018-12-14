using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLib.IncrementingResources
{
    public class CornResource : IncrementingResource
    {
        public CornResource() : 
            base(
                delta:  5, 
                value:  0, 
                name:   "Corn"
            )
        {
            
        }
    }
}
