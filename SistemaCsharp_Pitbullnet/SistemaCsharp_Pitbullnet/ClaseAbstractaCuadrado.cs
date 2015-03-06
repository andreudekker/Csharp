using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaCsharp_Pitbullnet
{
    class ClaseAbstractaCuadrado :ClaseAbstractaFirma
    {
         public override double Area()
        {
            return Math.Pow(this._lado, 2);
        }
        
        
            private double _lado;
            public ClaseAbstractaCuadrado(double lado)
                {
                    this._lado = lado;
                }
            
        public override void Dibujar()
            {
                Console.WriteLine("Dibujando  cuadrado");
            }



    }
}
