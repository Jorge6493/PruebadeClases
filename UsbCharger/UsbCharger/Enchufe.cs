using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsbCharger
{
    class Enchufe : PowerDelivery
    {
        string Region;
        public Enchufe(string region)
        {
            Region = region;
        }

        public string getRegion()
        {
            return Region;
        }
        public void printConnect()
        {
            Console.WriteLine("Al enchufe de region " + getRegion());
        }

    }
}
