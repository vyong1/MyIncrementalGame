using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MyIncrementalGame
{
    public class Core
    {
        List<Resource> Resources { get; } = new List<Resource>();
        private volatile bool running = true;
        private const int TickMS = 500;
        private Thread GameThread;
        

        public void AddResource(Resource resource)
        {
            this.Resources.Add(resource);
        }

        public void AddResources(List<Resource> resources)
        {
            this.Resources.AddRange(resources);
        }

        public void Start()
        {
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
            Console.WriteLine("====");
        }

        public void Tick()
        {
            foreach (Resource resource in Resources)
            {
                resource.Tick();
            }
        }
    }
}
