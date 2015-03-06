using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaCsharp_Pitbullnet
{
    class ClaseConMetodos 
    {      
        #region metodoConReturnSuma
        public int suma(int a , int b) //metodocoreferncia
        {
            int suma;
           suma = a+b;
           return suma;
        }
        #endregion
        
        #region funcionConCapturadeTexbox
        public int valor1 { get; set; }
        public int valor2 { get; set; }
         public int sumacontexbox(int valor1, int valor2)
         {
             int resultado;
             return resultado=valor1+valor2;
         }
        #endregion
        
        #region MetodoConReferencia
         public int numero { get; set; }
         public void cambiarNumero(ref int numero)
         {
             numero = 87655;
         }
#endregion
    }
    
}
