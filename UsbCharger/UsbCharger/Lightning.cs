using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsbCharger
{
    class Lightning : ICable
    {
        //string puerto;
        public Lightning()
        {
          //  puerto = celular.getPuerto();
        }
       // public string getPuerto()
        //{
          //  return puerto;
        //}
        public void printCable()
        {
            Console.WriteLine("Con el cable Lightning");
        }
    }
}
