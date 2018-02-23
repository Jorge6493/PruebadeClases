using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsbCharger
{
    class Celular
    {
        string nombre;
        string puerto;
        public Celular(string Nombre, string Puerto)
        {
            nombre = Nombre;
            puerto = Puerto;
        }
        public string getNombre()
        {
            return nombre;
        }
        public string getPuerto()
        {
            return puerto;
        }
        public void connectCelular(Cable cable)
        {
            Console.WriteLine("Al " + getNombre()+ " con el cable " + cable.getPuerto());// check S
            //Console.WriteLine();
        }
    }
}
