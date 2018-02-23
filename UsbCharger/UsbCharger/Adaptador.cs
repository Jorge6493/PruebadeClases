using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsbCharger
{
    class Adaptador : PowerDelivery
    {
        string regionDesde;
        string regionHasta;
        public Adaptador(string RegionDs, string RegionAs)
        {
            regionDesde = RegionDs;
            regionHasta = RegionAs;
        }
        public string getRegion()
        {
            return null;
        }

        public void printConnect()
        {
            Console.WriteLine("Con el adaptador de region " + regionDesde + " a la region " + regionHasta);
        }


    }
}
