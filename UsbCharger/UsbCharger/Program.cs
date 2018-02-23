using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsbCharger
{
    class Program
    {
        static void checkAdapter(Enchufe enchufe, Cabeza cabeza)
        {
            if (string.Compare(cabeza.getRegion(), enchufe.getRegion(), true) != 0)
            {
                Adaptador adaptador = new Adaptador(enchufe.getRegion(), cabeza.getRegion()); //check S
                adaptador.printConnect();
                //adaptador
            }
        }

        static void initCharge(string region1,string region2,string phone,string port)
        {
            Enchufe enchufe = new Enchufe(region1);
            Cabeza cabeza = new Cabeza(region2);
            Celular celular = new Celular(phone, port);
            CableFactory cableF = new CableFactory();

            enchufe.printConnect();
            cabeza.printConnect();
            checkAdapter(enchufe, cabeza);
            celular.connectCelular();
            ICable cable = cableF.GetCable(celular);
            cable.printCable();

        }

        static void Main(string[] args)
        {
            initCharge("USA", "Europa", "iPhone", "Lightning");
           

            Console.ReadKey();

        }
    }
}
