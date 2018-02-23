using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsbCharger
{
    interface PowerDelivery
    {
        string getRegion();
        void printConnect();
    }
}
