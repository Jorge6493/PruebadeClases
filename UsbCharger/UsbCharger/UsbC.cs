using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsbCharger
{
    class UsbC : ICable
    {
        //string puerto;
        public UsbC()
        {
            //puerto = celular.getPuerto();
        }
       // public string getPuerto()
        //{
          //  return puerto;
        //}
        public void printCable()
        {
            Console.WriteLine("Con el cable USB-C");
        }
    }
}
