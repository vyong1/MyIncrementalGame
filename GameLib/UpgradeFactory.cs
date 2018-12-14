using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLib
{
    public static class UpgradeFactory
    {
        public static Upgrade CreateResetUpgrade(double factor)
        {
            double oldValue = 0;
            UpgradeClause reset = new UpgradeClause(r =>
            {
                oldValue = r.Value;
                r.Value = 0;
            });

            UpgradeClause addToDelta = new UpgradeClause(r =>
            {
                r.Delta = Math.Round(r.Delta + oldValue * factor, 2);
            });

            IEnumerable<UpgradeClause> clauses = new List<UpgradeClause>()
            {
                reset,
                addToDelta
            };

            return new Upgrade(clauses);
        }
    }
}
