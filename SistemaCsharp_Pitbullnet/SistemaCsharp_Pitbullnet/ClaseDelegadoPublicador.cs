using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaCsharp_Pitbullnet
{
    class ClaseDelegadoPublicador
    {
        public delegate void FirmaEventoApublicar(string texto);//creacion delegado
        public FirmaEventoApublicar EventoApublicar; //apuntador
        public void OcurrioEvento(string texto)
        {
            EventoApublicar(texto);
        }

    }
}
