using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDevice
{
    public class GSM
    {
        //fields
        private static string iPhone4S = "Not a Smartphone !";

        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery phoneBattery;
        private Display phoneDisplay;
        private List<Call> callHistory = new List<Call>();

        //constructors
        public GSM(string currentModel, string currentManufacturer)
        {
            this.Model = currentModel;
            this.Manufacturer = currentManufacturer;
            this.Price = 0.0M;
            this.Owner = string.Empty;
        }

        public GSM(string currentModel, string currentManufacturer, decimal currentPrice, string currentOwner)
            : this(currentModel, currentManufacturer)
        {
            this.Price = currentPrice;
            this.Owner = currentOwner;
        }

        public GSM(string currentModel, string currentManufacturer, Battery currentBattery, Display currentDisplay)
            : this(currentModel, currentManufacturer)
        {
            this.PhoneBattery = currentBattery;
            this.PhoneDisplay = currentDisplay;
        }

        //Methods
        public override string ToString()
        {
            return this.Model + " " + this.Manufacturer + " " + this.Price + " " + this.Owner;
        }

        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
        }

        public void DeleteCall(Call call)
        {
            int index = callHistory.IndexOf(call);
            if (index != -1)
            {
                this.callHistory.Remove(call); 
            }
            
        }

        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }

        public decimal CalculateTotalPrice(decimal pricePerMinute)
        {
            decimal totalPrice = 0;
            decimal coef = 60000;
            for (int i = 0; i < this.CallHistory.Count; i++)
            {
                totalPrice += (this.CallHistory[i].Duration / coef) * pricePerMinute;
            }
            
            return totalPrice;
        }
        //properties
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value != string.Empty)
                {
                    this.model = value;
                }
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value != string.Empty)
                {
                    this.manufacturer = value;
                }
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value > 200)
                {
                    this.price = value;
                }
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (value.Length > 3)
                {
                    this.owner = value;
                }
            }
        }

        public Battery PhoneBattery
        {
            get
            {
                return this.phoneBattery;
            }
            set
            {
                this.phoneBattery = value;
            }
        }

        public Display PhoneDisplay
        {
            get
            {
                return this.phoneDisplay;
            }
            set
            {
                this.phoneDisplay = value;
            }
        }
        public static string Iphone4S
        {
            get
            {
                return iPhone4S;
            }
            set
            {
                iPhone4S = value;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
            set
            {
                this.callHistory = value;
            }
        }
    }
}
