using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDevice
{
    public class Battery
    {
        //fields
        private string batteryModel;
        private double hoursIdle;
        private double hoursTalk;
        private BatteryType type;

        //constructors
        public Battery(string currentBatteryModel)
        {
            this.BatteryModel = currentBatteryModel;
        }

        public Battery(string currentBatteryModel, double currentHoursIdle, double currentHoursTalk)
            : this(currentBatteryModel)
        {
            this.HoursIdle = currentHoursIdle;
            this.HoursTalk = currentHoursTalk;
        }

        public Battery(string currentBatteryModel, BatteryType currentType)
            : this(currentBatteryModel)
        {
            this.type = currentType;
        }

        //Methods
        public override string ToString()
        {
            return this.BatteryModel + " " + this.HoursIdle + " " + this.HoursTalk;
        }

        //properties
        public string BatteryModel
        {
            get
            {
                return this.batteryModel;
            }
            set
            {
                if (value != string.Empty)
                {
                    this.batteryModel = value;
                }
            }
        }

        public double HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value > 15)
                {
                    this.hoursIdle = value;
                }
            }
        }

        public double HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value > 5 && value < 15)
                {
                    this.hoursTalk = value;
                }
            }
        }

    }
}
