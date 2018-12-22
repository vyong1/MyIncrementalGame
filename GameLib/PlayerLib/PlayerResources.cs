using GameLib.IncrementingResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLib.PlayerLib
{
    public class PlayerResources
    {
        public Corn Corn { get; set; }
        public Wheat Wheat { get; set; }

        public PlayerResources()
        {
            Corn = new Corn();
            Wheat = new Wheat();
        }
    }
}
