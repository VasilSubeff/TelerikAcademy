using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDevice
{
    public class Call
    {
        private string date;
        private string time;
        private string dialedPhoneNumber;
        private ulong duration;

        
        public Call(string currentDate, string currentTime, string currentDialedPhoneNumber, ulong currentDuration)
        {
            this.Date = currentDate;
            this.Time = currentTime;
            this.DialedPhoneNumber = currentDialedPhoneNumber;
            this.Duration = currentDuration;
        }

        public string Date 
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }

        public string Time
        {
            get
            {
                return this.time;
            }
            set
            {
                this.time = value;
            }
        }

        public string DialedPhoneNumber
        {
            get
            {
                return this.dialedPhoneNumber;
            }
            set
            {
                this.dialedPhoneNumber = value;
            }
        }

        public ulong Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                this.duration = value;
            }
        }

    }
}
