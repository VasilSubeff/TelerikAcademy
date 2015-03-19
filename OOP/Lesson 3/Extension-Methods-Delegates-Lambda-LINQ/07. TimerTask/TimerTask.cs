using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerTask
{
    class TimerTask
    {
        static void Main()
        {
            Timer timer = new Timer(1000, 10, delegate() { Console.WriteLine(DateTime.Now); });
            timer.Run();
        }
    }
}
