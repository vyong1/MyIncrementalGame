using GameLib;
using GameLib.IncrementingResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLib
{
    public class PlayerResources : Tickable
    {
        public Corn Corn { get; set; }
        public Wheat Wheat { get; set; }

        public PlayerResources()
        {
            Corn = new Corn();
            Wheat = new Wheat();
        }

        public void Tick()
        {
            Corn.Tick();
            Wheat.Tick();
        }
    }
}
