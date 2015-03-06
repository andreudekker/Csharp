using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaCsharp_Pitbullnet
{
    class ClaseConPolimorfismos
    {
        public string color { get; set; }   //propiedades
        public string ruedas { get; set; } 
        public string  puertas  { get; set; } 
      
        public string miVehiculo(string color, string ruedas, string puertas)  //metodo con parametros
        {           
            Console.WriteLine("Metodo con parametros");
            Console.WriteLine("Color"+ color + "Cantidad de ruedas" + ruedas + "Numero de puertas" + puertas);
            return color + ruedas + puertas;
        }
      
        public string miVehiculo()  //metodos sin parametros
        {
            color = "Azul";     //propiedades
            ruedas = "4";
            puertas = "4";
            Console.WriteLine("Metodo sin parametros");
            Console.WriteLine("Color" + color + "Cantidad de ruedas" + ruedas + "Numero de puertas" + puertas);
            return color+ruedas+puertas;
        }
    }
}
