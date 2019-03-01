using GameLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLib
{
    public class Player : Tickable
    {
        public PlayerResources Resources { get; }

        public Player()
        {
            Resources = new PlayerResources();
        }

        public void Tick()
        {
            Resources.Tick();
        }
    }
}
