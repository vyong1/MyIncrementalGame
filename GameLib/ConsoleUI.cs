using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLib
{
    public class ConsoleUI : Tickable
    {
        private IEnumerable<Resource> Resources { get; set; }

        private bool CurrentlyPrintingResources { get; set; } = false;

        public ConsoleUI(IEnumerable<Resource> resources)
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

                }
            }
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
            foreach (Resource r in Resources)
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
