using GameLib;
using System;
using System.Threading;

namespace GameLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Core c = new Core();
            c.Resources.Add(new CornResource());
            c.Resources.Add(new WheatResource());
            c.Start();

            // Indefinite wait
            Console.Read();

            c.Stop();
        }
    }
}
