using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDevice
{
    public class Display
    {
        //fields
        private double displaySize;
        private long numberOfColors;

        //constructors
        public Display(double currentDisplaySize, long currentNumberOfColors)
        {
            this.DisplaySize = currentDisplaySize;
            this.NumberOfColors = currentNumberOfColors;
        }

        //properties
        public double DisplaySize
        {
            get
            {
                return this.displaySize;
            }
            set
            {
                if (value > 1.5)
                {
                    this.displaySize = value;
                }
                else
                {
                    throw new ArgumentException("Invalid display Size");
                }
            }
        }

        public long NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                if (numberOfColors < 10)
                {
                    this.numberOfColors = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
    }
}
