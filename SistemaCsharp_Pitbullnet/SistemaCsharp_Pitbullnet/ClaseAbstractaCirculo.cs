using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaCsharp_Pitbullnet
{
	class ClaseAbstractaCirculo :ClaseAbstractaFirma  //llamado a la clase
	{
		public override double Area()
		{
			return Math.PI * Math.Pow(this._radio, 2);
		}

	   private double _radio;

	   public ClaseAbstractaCirculo(double radio)
		{
			this._radio = radio;
		
		}

		public override void Dibujar()  //revisar para mostrar en el listbox 
		{
			Console.WriteLine("Dibujando circulo");
		}
	}
}
