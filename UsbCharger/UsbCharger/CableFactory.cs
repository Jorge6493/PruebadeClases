using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsbCharger
{
    class CableFactory
    {
        public ICable GetCable(Celular celular)
        {
            //string port = celular.getPuerto();
            if (string.Compare(celular.getPuerto(),"USB-C",true)== 0)
            {
                return new UsbC();
            }
            else if (string.Compare(celular.getPuerto(), "Lightning", true) == 0)
            {
                return new Lightning();
            }

            return null;
        }
    }
}
