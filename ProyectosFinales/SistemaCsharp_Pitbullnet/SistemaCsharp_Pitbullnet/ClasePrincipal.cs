using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaCsharp_Pitbullnet
{
    class ClasePrincipal  //clase con solo propiedades
    {
        public int numero { get; set; }  //propiedades
        public string mensaje { get; set; } // propiedades
        public float flotante { get; set; } // propiedades

        public string mensajeConHerencia { get; set; }
        public virtual string MensajeyHerencia()
        {
            mensajeConHerencia = "Soy un metodo dentro de una clase principal ";
            return mensajeConHerencia;
        }
    
    }
        

}
