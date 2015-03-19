using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDevice
{
    public class PhoneDeviceMain
    {
        static void Main(string[] args)
        {
            GSM htc = new GSM("One", "HTC", 680, "John Doe");
            GSM samsung = new GSM("Galaxy", "Samsung", 580, "Jane Done");

            Battery hTCBattery = new Battery("Standard Battery", 30.5, 12);
            Battery samsungBattery = new Battery("Non-standard Battery", 28.7, 10);
            Battery appleBattery = new Battery("K-Mobile", 20, 6);

            BatteryType htcBatteryType = BatteryType.Li_Ion;
            Battery hTCBatteryWithType = new Battery("Standard Battery", htcBatteryType);

            Display hTCDisplay = new Display(4.8, 160000);
            Display samsungDisplay = new Display(5, 120000);
            Display appleDisplay = new Display(4, 1000);

            GSM iPhone = new GSM("6 Plus", "Apple", appleBattery, appleDisplay);
            Console.WriteLine(iPhone.ToString());
            Console.WriteLine(samsung.ToString());

            Console.WriteLine(samsung.Model);
            samsung.Model = "Galaxy S5";
            Console.WriteLine(samsung.Model);

            Console.WriteLine(htc.Manufacturer);
            htc.Manufacturer = "HTC Corp";
            Console.WriteLine(htc.Manufacturer);

            htc.Price = 1050.20M;
            htc.Owner = "Jane Dawson";
            Console.WriteLine(htc.ToString());

            Console.WriteLine(appleBattery.ToString());

            Console.WriteLine(GSM.Iphone4S);
            GSM.Iphone4S = "Not a smartphone too !";
            Console.WriteLine(GSM.Iphone4S);

            GSM[] devices = GSMTest.CreateGSMDevices(10);
            Console.WriteLine(devices[2].Price);

            for (int i = 0; i < devices.Length; i++)
            {
                Console.Write(devices[i].Manufacturer + " ");
            }
            Console.WriteLine();

            Console.WriteLine(devices[4].PhoneBattery.BatteryModel);
            Console.WriteLine(devices[4].PhoneDisplay.NumberOfColors);

            //Call firstCall = new Call(11.11.2015, 10:12:23, "123-345-676", 123767373);

            Call firstCall = new Call("12-12-2015", "12:12:12", "123-123-123", 60000);
            Call secondCall = new Call("10-10-2015", "13:13:13", "456-456-456", 120000);

            samsung.AddCall(firstCall);
            
            htc.AddCall(secondCall);
            htc.AddCall(firstCall);
            htc.DeleteCall(firstCall);
            htc.AddCall(firstCall);
            Console.WriteLine(htc.CalculateTotalPrice(2));
            htc.ClearCallHistory();
            Console.WriteLine(htc.CalculateTotalPrice(2));

            GSMCallHistoryTest test = new GSMCallHistoryTest();
            test.TestCallHistory();



            
        }
    }
}
