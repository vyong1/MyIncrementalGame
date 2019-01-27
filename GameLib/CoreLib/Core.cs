using GameLib.IncrementingResources;
using GameLib.PlayerLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace GameLib.CoreLib
{
    /// <summary>
    /// Coordinates a HeartBeat to tick Resources and a UI
    /// </summary>
    public class Core
    {
        private HeartBeat HeartBeat { get; set; }

        private List<Tickable> Tickables { get; set; }

        public Player Player { get; }

        public Core(int tickMS = 500)
        {
            HeartBeat = new HeartBeat(tickMS, Tick);
            Tickables = new List<Tickable>();

            Tickables.Add(new Player());
        }

        public void Start()
        {
            HeartBeat.Start();
        }

        public void Stop()
        {
            HeartBeat.Stop();
        }

        private void Tick()
        {
            Player.Tick();
        }
    }
}
