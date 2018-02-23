using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace UsbCharger
{
    class Cabeza : PowerDelivery
    {
        string Region;
        public Cabeza(string region)
        {
            Region = region;
        }
        public string getRegion()
        {
            return Region;
        }
        public void printConnect()
        {

            Console.WriteLine("Se conecta la cabeza de region " + getRegion());

            
        }

    }
}
