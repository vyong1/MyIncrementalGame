using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace GameLib
{
    public class HeartBeat
    {
        public int DelayMS { get; }

        private Timer Timer { get; set; }

        private Action Func { get; set; }
        
        public HeartBeat(int delayMS, Action func)
        {
            DelayMS = delayMS;
            Func = func;
            
            Timer = new Timer(DelayMS);
            Timer.Elapsed += OnElapsed;
            Timer.AutoReset = true;
        }

        public void Start()
        {
            Timer.Start();
        }

        public void Stop()
        {
            Timer.Stop();
        }

        private void OnElapsed(object source, ElapsedEventArgs e)
        {
            Func.Invoke();
        }
    }
}
