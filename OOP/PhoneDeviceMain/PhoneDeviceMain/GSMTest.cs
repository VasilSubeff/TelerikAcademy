using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDevice
{
    public class GSMTest
    {
        
        public static GSM[] CreateGSMDevices(int numberOfDevices)
        {
            Battery[] batteries = new Battery[numberOfDevices];

            for (int i = 0; i < batteries.Length; i++)
            {
                batteries[i] = new Battery("Standard" + i);
            }

            Display[] displays = new Display[numberOfDevices];

            for (int i = 0; i < displays.Length; i++)
            {
                displays[i] = new Display(2.5 + i, 1000 + (i * 100));
            }

            GSM[] multipleGSMDevices = new GSM[numberOfDevices];

            for (int i = 0; i < multipleGSMDevices.Length; i++)
            {
                multipleGSMDevices[i] = new GSM("One M8", "HTC", batteries[i], displays[i]);
            }

            return multipleGSMDevices;
        }
    }
}
