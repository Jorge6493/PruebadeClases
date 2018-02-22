using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace UsbCharger
{
    class Cabeza
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
        public void connectCabeza(Enchufe enchufe)
        {
            string regionEnchufe = enchufe.getRegion();
            //Console.WriteLine("string compare result = " + string.Compare(getRegion(), regionEnchufe, true));

            Console.WriteLine("Se conecta la cabeza de region " + getRegion());

            if (string.Compare(getRegion(), regionEnchufe, true) != 0)
            {
                Adaptador adaptador = new Adaptador(regionEnchufe, getRegion());
                adaptador.connectAdaptador();
                //adaptador
            }
        }
    }
}
