using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsbCharger
{
    class Cable
    {
        string puerto;
        public Cable(Celular celular)
        {
            puerto = celular.getPuerto();
        }
        public string getPuerto()
        {
            return puerto;
        }
    }
}
