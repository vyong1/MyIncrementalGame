using GameLib.IncrementingResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace GameLib
{
    /// <summary>
    /// Coordinates a HeartBeat to tick Resources and a UI
    /// </summary>
    public class Core
    {
        private HeartBeat HeartBeat { get; set; }

        private List<Tickable> Tickables { get; set; }

        private object mutex = new object();

        public Core(int tickMS = 500)
        {
            HeartBeat = new HeartBeat(tickMS, Tick);
            Tickables = new List<Tickable>();
        }

        public void Start()
        {
            HeartBeat.Start();
        }

        public void Stop()
        {
            HeartBeat.Stop();
        }

        public void RegisterEntity(Tickable tickable)
        {
            lock (mutex)
            {
                Tickables.Add(tickable);
            }
        }

        public void DeregisterEntity(Tickable tickable)
        {
            lock (mutex)
            {
                Tickables.Remove(tickable);
            }
        }

        private void Tick()
        {
            lock (mutex)
            {
                foreach (Tickable tickable in Tickables)
                {
                    tickable.Tick();
                }
            }
        }
    }
}
