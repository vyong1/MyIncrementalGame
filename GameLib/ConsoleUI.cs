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

        public ConsoleUI(IEnumerable<Resource> resources)
        {
            Resources = resources;
        }

        public void Tick()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("============");
            foreach (Resource r in Resources)
            {
                Console.WriteLine(r.ToString());
            }
            Console.WriteLine("====\n");
            Console.Out.Flush();
        }
    }
}
