using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegados
{
   
    delegate void escribemensaje (string mensaje);
    class ClienteDelegado
    {

        public escribemensaje direcciondelMetodo; //usar delegados predefinidos , en lo posible no crearlos
        
        public int divide(int a, int b)
        {
            int c = 0;
            if (b == 0)
            {
                if (direcciondelMetodo !=null)
                {
                    direcciondelMetodo("Dentro de divide: divide  entre 0"); // direccion del metodo que apunta a ejemplo y al metodo escribe;
                }
                
                //throw new Exception("No puedes dividir entre 0"); excepcion;
            }
            else
            {
                 c = a / b;
            }
            return c;
        
        }


        //se conoce como el metodo callback
        #region Delegados_recibe_direccion
        
        public int divide(int a, int b, Action<string> direccion)
        {
            int c = 0;
            if (b == 0)
            {
                if (direccion != null)
                {
                    direccion("Dentro de divide: division entre 0"); // direccion del metodo que apunta a ejemplo y al metodo escribe;
                }

            }
            else
            {
                c = a / b;
            }
            return c;

        }
        #endregion








    }
}
