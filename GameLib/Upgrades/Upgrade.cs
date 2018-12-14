using GameLib.IncrementingResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLib.Upgrades
{
    public class Upgrade
    {
        private IEnumerable<UpgradeClause> Clauses { get; set; }

        public Upgrade(Action<IncrementingResource> func)
        {
            Clauses = new List<UpgradeClause>() { new UpgradeClause(func) };
        }

        public Upgrade(IEnumerable<UpgradeClause> clauses)
        {
            Clauses = clauses;
        }

        public void ApplyTo(IncrementingResource resource)
        {
            foreach (UpgradeClause clause in Clauses)
            {
                clause.ExecuteOn(resource);
            }
        }
    }
}
