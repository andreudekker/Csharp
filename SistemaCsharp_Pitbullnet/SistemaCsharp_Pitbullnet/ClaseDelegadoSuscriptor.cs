using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaCsharp_Pitbullnet
{
    class ClaseDelegadoSuscriptor
    {
        public void avisemeAqui(string texto)
        {
            MessageBox.Show("Gracias por avisar este es el mensaje recibido"+ texto);
        }
    }
}
