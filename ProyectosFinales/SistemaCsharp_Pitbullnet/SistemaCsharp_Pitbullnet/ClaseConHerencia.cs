using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaCsharp_Pitbullnet
{
    class ClaseConHerencia :ClasePrincipal
    {
       
         
        public override string MensajeyHerencia()
        {
           mensajeConHerencia = "Soy un metodo dentro de una clase con herencia";
            return mensajeConHerencia;
        }

    }
}
