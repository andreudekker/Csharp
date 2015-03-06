using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polimorfismo
{
    class vehiculo
    {
        public String Color { get; set; }
        public int Ruedas { get; set; }
        public int Puertas { get; set; }

        public void miVehiculo(string Color, int Ruedas, int Puertas)
        {
            Console.WriteLine("Metodo con parametros");
            Console.WriteLine("Color" + Color + "Cantidad de ruedas" + Ruedas + "Cantidad de puertas" + Puertas);
         

        }
        public void miVehiculo()
        {
            Color = "Azul";
            Ruedas = 4;
            Puertas = 4;
            Console.WriteLine("Metodo sin parametros");
            Console.WriteLine("Color" + Color + "Cantidad de ruedas" + Ruedas + "Cantidad de puertas" + Puertas);
         

        }
    }
}
