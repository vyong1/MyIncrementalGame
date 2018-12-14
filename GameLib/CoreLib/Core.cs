using GameLib.IncrementingResources;
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

        public ResourceData Resources { get; }

        private ConsoleUI UI { get; set; }

        private Thread UIThread { get; set; }

        public Core(int tickMS = 500)
        {
            HeartBeat = new HeartBeat(tickMS, Tick);
            Resources = new ResourceData();
            UI = new ConsoleUI(Resources);

            UIThread = new Thread(UI.InterpretInput);
        }

        public void Start()
        {
            HeartBeat.Start();
            UIThread.Start();
        }

        public void Stop()
        {
            HeartBeat.Stop();
            UIThread.Join();
        }

        private void Tick()
        {
            Resources.Tick();
            UI.Tick();
        }
    }
}
