using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegados
{
    class Ejemplos
    {

        public  void ejemplodelegado()
        {
            ClienteDelegado cd = new ClienteDelegado();

            cd.direcciondelMetodo = escribe; // apunta al metodo escribe
            cd.direcciondelMetodo += escribe2; //dispara el metodo escribe2
            //cd.direcciondelMetodo += escribe3; // no permite parametro diferentes
           
           //  escribe("division entre 0");//llama al metodo escribe;
           // escribe2("mensaje del metodo escribe 2");


            
            Console.WriteLine(cd.divide(4,2));
        }

        //--------------------------------------------
       
        #region DelegadoAnonimo

        //public void ejemplodelegadoAnonimo()
        //{
        //    ClienteDelegado cd = new ClienteDelegado();
        //    cd.direcciondelMetodo = delegate(string mensaje)
        //                            {
        //                                Console.WriteLine("Delegado Anonimo: {0}",mensaje); 
        //                            }; // Evita escribir por todos lados metodos
            
        //   // cd.direcciondelMetodo += escribe2; // prueba para llamar a  otro metodo 
        //                                        // -= quitar la direccion del metodo
            
        //    Console.WriteLine(cd.divide(232,2));
        //}
        #endregion

       //------------------------------------------------
        
        # region Delegado_lambda

        //public void ejemplodelegadoconLambda()
        //{
        //    ClienteDelegado cd = new ClienteDelegado();
        //                        cd.direcciondelMetodo = (mensaje) => //operador Lambda =>
        //                        {    
        //                            Console.WriteLine("Delegado lambda {0}", mensaje);
        //                        };
        //                        Console.WriteLine(cd.divide(100,2));        
        //}

        #endregion

        //------------------------------------------------

        #region lambda con una expresion
        
        //public void ejemplodelegadoconLambdaconunaexpresion()
        //{
        //    ClienteDelegado cd = new ClienteDelegado();
        //    cd.direcciondelMetodo = mensaje => //operador Lambda =>
        //                            Console.WriteLine("Delegado lambda una expresion {0}", mensaje);
        //                            Console.WriteLine(cd.divide(400,2));
                       
        //}
        
        #endregion

        //------------------------------------------------

        #region delegado personalizado

        public void ejemplodelegadopersonalizado()
        {
            ClienteDelegado clien = new ClienteDelegado();
            Action<string> direccion;
            direccion = escribe;

            Console.WriteLine(clien.divide(2200,2, escribe));//callback
        }
        
        
        #endregion

        //-------------------------------------------------------------
  


        #region Metodos_para_ser_llamados_por_el_delegado

        static void escribe(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        static void escribe2(string mensaje)
        {
            Console.WriteLine("Escribe2: {0}" + " ", mensaje);
        }

        //static void escribe3(int mensaje)  // no es le mismo tipo de firma obligatorio el mismo valor
        //{
        //    Console.WriteLine("escribe3:{0}", mensaje);
        //}

        #endregion

    }
}
