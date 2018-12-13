using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GameLib
{
    public class Core
    {
        public List<Resource> Resources { get; } = new List<Resource>();
        private bool started = false;
        private volatile bool running = true;
        private const int TickMS = 500;
        private Thread GameThread;

        public void Start()
        {
            // Only allow for 1 start
            if(started == true)
            {
                return;
            }

            started = true;
            GameThread = new Thread(new ThreadStart(GameLoop));
            GameThread.Start();
        }

        public void Stop()
        {
            this.running = false;

            GameThread.Join();
        }

        private void GameLoop()
        {
            while(running == true)
            {
                Tick();
                PrintResources();
                Thread.Sleep(TickMS);
            }
        }

        public void PrintResources()
        {
            Console.WriteLine("============");
            Resources.ForEach(r => Console.WriteLine(r.ToString()));
            Console.WriteLine("====\n");
        }

        private void Tick()
        {
            foreach (Resource resource in Resources)
            {
                resource.Tick();
            }
        }
    }
}
