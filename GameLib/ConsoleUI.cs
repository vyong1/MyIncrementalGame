using GameLib.CoreLib;
using GameLib.IncrementingResources;
using GameLib.Upgrades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLib
{
    /// <summary>
    /// This is just a temporary console UI to test out code
    /// </summary>
    [Obsolete]
    public class ConsoleUI : Tickable
    {
        /*
           DEPRECATED 
        */

        private IEnumerable<IncrementingResource> Resources { get; set; }

        private bool CurrentlyPrintingResources { get; set; } = false;

        public ConsoleUI(IEnumerable<IncrementingResource> resources)
        {
            Resources = resources;
        }

        public void InterpretInput()
        {
            string option = "";

            while(!option.Equals("3"))
            {
                Clear();
                PrintMenu();
                option = Console.ReadLine();

                if (option.Equals("1"))
                {
                    CurrentlyPrintingResources = true;
                    PrintResources();
                    Console.ReadLine();
                    CurrentlyPrintingResources = false;
                }
                else if (option.Equals("2"))
                {
                    UpgradeResourcePrompt();
                }
            }
        }

        private void UpgradeResourcePrompt()
        {
            Clear();
            Console.WriteLine("Upgrade the delta of a resource by 1% of " +
                "it's value, and reset the value to 0.");
            Console.WriteLine("Enter the name of the resource to upgrade: ");
            string resourceName = Console.ReadLine().ToLower();

            var toUpgrade = Resources.Where(resource => resource.Name.ToLower().Equals(resourceName));

            if(!toUpgrade.Any()) // Resource not found
            {
                Console.WriteLine(string.Format("Resource \"{0}\" not found.", resourceName));
                Console.WriteLine("Press enter to return to the menu");
                Console.ReadLine();
                return;
            }

            foreach (IncrementingResource r in toUpgrade)
            {
                double old = r.Delta;
                // BaseUpgrade resetUpgrade = UpgradeFactory.CreateResetUpgrade(0.01);
                // r.ApplyUpgrade(resetUpgrade);
                Console.WriteLine(string.Format("Resource \"{0}\" delta upgraded from {1} to {2}", r.Name, old, r.Delta));
            }

            Console.WriteLine("Press enter to return to the menu");
            Console.ReadLine();
        }

        public void PrintMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("(1) Print resources");
            Console.WriteLine("(2) Upgrade");
            Console.WriteLine("(3) Exit");
            Console.WriteLine("Enter your choice: ");
            Console.Out.Flush();
        }

        public void Clear()
        {
            Console.Clear();
        }

        public void PrintResources()
        {
            Clear();
            Console.WriteLine("Resources:");
            foreach (IncrementingResource r in Resources)
            {
                Console.WriteLine("  " + r.ToString());
            }
            Console.WriteLine("\nPress enter to return to the menu");
            Console.Out.Flush();
        }

        public void Tick()
        {
            if (CurrentlyPrintingResources)
            {
                // Update with the new value of the resources
                PrintResources();
            }
            else
            {
                // Do nothing
            }
        }
    }
}
