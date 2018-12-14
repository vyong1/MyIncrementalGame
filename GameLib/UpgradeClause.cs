using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLib
{
    public class UpgradeClause
    {
        private Action<Resource> Action { get; set; }

        public UpgradeClause(Action<Resource> action)
        {
            Action = action;
        }

        public void ExecuteOn(Resource resource)
        {
            Action.Invoke(resource);
        }
    }
}
