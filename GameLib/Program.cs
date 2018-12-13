using GameLib;
using System;
using System.Threading;

namespace GameLib
{
    /*
        Idea:
            Farming incremental game
            
            Crops grow faster if there are more crops
            Sell crops for money
            Buy other crops with money
            Spend money on farm upgrades
    */

    class Program
    {
        static void Main(string[] args)
        {
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
