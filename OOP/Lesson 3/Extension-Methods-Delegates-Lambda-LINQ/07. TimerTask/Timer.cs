using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TimerTask
{
    public delegate void TimerDLG();

    class Timer
    {
        public int MiliSeconds { get; set; }
        public int TimesToRun { get; set; }
        public TimerDLG TimerDelegate { get; set; }

        public Timer(int currentMSeconds, int currentTimesToRun, TimerDLG currentDLG)
        {
            this.MiliSeconds = currentMSeconds;
            this.TimesToRun = currentTimesToRun;
            this.TimerDelegate = currentDLG;
        }

        public void Run()
        {
            for (int i = 0; i < this.TimesToRun; i++)
            {
                Thread.Sleep(this.MiliSeconds);
                TimerDelegate();
            }
            
        }
        
    }
}
