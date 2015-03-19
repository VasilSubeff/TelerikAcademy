using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDevice
{
    public class GSMCallHistoryTest
    {
        public const decimal PricePerMinute = 0.37M;

        public void TestCallHistory()
        {
            GSM testGSM = new GSM("One M8", "HTC", 123.32M, "John Doe");

            List<Call> someCalls = new List<Call>();

            for (int i = 0; i < 5; i++)
            {
                someCalls.Add(new Call("12.12.2015", "18:18:18", "12332-1232-2" + i, 56 + (ulong)((i + 1) * 61000)));
            }

            Console.WriteLine("There are {0} calls added.", someCalls.Count);
            foreach (var call in someCalls)
            {
                testGSM.AddCall(call);
            }

            for (int i = 0; i < testGSM.CallHistory.Count; i++)
            {
                Console.WriteLine("Call {0}: {1} {2} - to number {3} - duration: {4} minutes", i+1,  testGSM.CallHistory[i].Date, 
                    testGSM.CallHistory[i].Time, testGSM.CallHistory[i].DialedPhoneNumber, testGSM.CallHistory[i].Duration / 60000);
            }


            Console.WriteLine("The total price for all calls is {0}.", testGSM.CalculateTotalPrice(PricePerMinute));

            ulong longestCall = 0;
            int longestCallIndex = 0;
            for (int i = 0; i < testGSM.CallHistory.Count; i++)
            {
                if (longestCall < testGSM.CallHistory[i].Duration)
                {
                    longestCall = testGSM.CallHistory[i].Duration;
                    longestCallIndex = i;
                }
            }
            Console.WriteLine("The longest call has duration of {0} minutes and it has been removed from the call history.", longestCall / 60000);
            testGSM.DeleteCall(testGSM.CallHistory[longestCallIndex]);
            Console.WriteLine("The remained calls are:");

            for (int i = 0; i < testGSM.CallHistory.Count; i++)
            {
                Console.WriteLine("Call {0}: {1} {2} - to number {3} - duration: {4} minutes", i+1,  testGSM.CallHistory[i].Date, 
                    testGSM.CallHistory[i].Time, testGSM.CallHistory[i].DialedPhoneNumber, testGSM.CallHistory[i].Duration / 60000);
            }

            Console.WriteLine("The new price for all calls is {0}. ", testGSM.CalculateTotalPrice(PricePerMinute));

        }
        

        

        
    }
}
