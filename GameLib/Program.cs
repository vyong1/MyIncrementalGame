using GameLib;
using GameLib.CoreLib;
using GameLib.IncrementingResources;
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
            Core core = new Core();
            core.Resources.Add(new CornResource());
            core.Resources.Add(new WheatResource());
            
            core.Start();
        }
    }
}
