using System;
using System.Threading;

namespace MyIncrementalGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Core c = new Core();
            c.AddResource(new Resource { Name = "A", Delta = 0.1, Value = 0 });
            c.AddResource(new Resource { Name = "B", Delta = 0.1, Value = 200 });
            c.Start();

            // Indefinite wait
            Console.Read();

            c.Stop();
        }
    }
}
