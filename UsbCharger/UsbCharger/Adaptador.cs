using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsbCharger
{
    class Adaptador
    {
        string regionDesde;
        string regionHasta;
        public Adaptador(string RegionDs, string RegionAs)
        {
            regionDesde = RegionDs;
            regionHasta = RegionAs;
        }

        public void connectAdaptador()
        {
            Console.WriteLine("Con el adaptador de region " + regionDesde + " a la region " + regionHasta);
        }
    }
}
