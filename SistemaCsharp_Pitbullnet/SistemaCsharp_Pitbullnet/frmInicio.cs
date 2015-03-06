using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Xml;

namespace SistemaCsharp_Pitbullnet
{
	public partial class frmInicio : Form
	{
		public frmInicio()
		{
			InitializeComponent();
		}

		private void btnMensaje_Click(object sender, EventArgs e)
		{
			#region valoresCajadeTexto
			string datosusuario="Hola Developer";
			txtValor1.Text =datosusuario;
			txtValor2.Text = datosusuario;
			#endregion
		}

		private void btnListView_Click(object sender, EventArgs e)
		{
			#region mensajeAlListView
			string mensajelstbox = "Mensaje generado para lstBox";
			lstDatos.Items.Add(mensajelstbox);
			#endregion
		}
		private void btnTiposDeDatos_Click(object sender, EventArgs e)
		{
			#region tiposDeDatos
			string mensaje = "10";
			int y = 10;
			float z = 2.5f;
			int resultado = int.Parse(mensaje) + y;
			resultado = resultado + Convert.ToInt32(Math.Ceiling(z));
			txtValor2.Text = resultado.ToString();
			#endregion
		}

		private void btnIf_Click(object sender, EventArgs e)
		{
			#region if
			try
			{
				int mensajeGanador = 0;
				mensajeGanador = int.Parse(txtValor1.Text);
				if (mensajeGanador == 1)
				{
					lstDatos.Items.Add("Ganaste");
				}
				else
				{
					lstDatos.Items.Add("Intentalo de nuevo");
				}

			}
			catch (FormatException)
			{

				lstDatos.Items.Add("Ingresa un numero del 1 al 3");
				lstDatos.Items.Add("En el campo de texto valor 1");
				lstDatos.Items.Add("Presiona if nuevamente");
		
			}
		   


			#endregion
		}

		private void btnIfElse_Click(object sender, EventArgs e)
		{
			#region if-else
			string mensajesaludo = "hola";
			  mensajesaludo=txtValor1.Text;
			if (mensajesaludo=="hola")
			{
				lstDatos.Items.Add("Hola,Developer");
			}
			else if (mensajesaludo == "adios")
			{
				lstDatos.Items.Add("Hasta pronto");
			}
			else
			{
				lstDatos.Items.Add("Me Repites de nuevo :C");
			}
			#endregion
		}

		private void btnSwitch_Click(object sender, EventArgs e)
		{
			#region switch

			try
			{
				int opcionluz;
				opcionluz = int.Parse(txtValor1.Text);

				switch (opcionluz)
				{
					case 1:
						lstDatos.Items.Add("Luz encendida");
						break;
					case 2:
						lstDatos.Items.Add("Luz apagada");
						break;
					default:
						lstDatos.Items.Add("Intentalo de nuevo");
						break;

				}


			}
			catch (FormatException)
			{

				lstDatos.Items.Add("Ingresa un numero del 1 al 3");
				lstDatos.Items.Add("<En la caja de texto, valor 1>");
			}
			
			
			#endregion
		}

		private void btnWhile_Click(object sender, EventArgs e)
		{
			#region while
			int n = 0;
			while (n <= 6)
			{
				lstDatos.Items.Add(n);
				n++;
			}
			#endregion
		}

		private void btnDoWhile_Click(object sender, EventArgs e)
		{
			#region dowhile
			int x = 0;
			do
			{
				lstDatos.Items.Add(x);
				x++;
			} 
			while (x < 5);
			#endregion
		}

		private void btnArregloUnidimensional_Click(object sender, EventArgs e)
		{
			#region arreglo unidimensional
		   
			int[] numeros = new int[6] { 12, 34, 48, 65, 64, 73 };
			foreach (var n in numeros)
			{
			   lstDatos.Items.Add(n);
			}
		   
			string[] colores = { "verde", "amarillo", "rojo" };
			for (int i = 0; i < colores.Length; i++)
			{
				lstDatos.Items.Add(colores[i]);
			}
			#endregion
		}

		private void btnArregloBidimensional_Click(object sender, EventArgs e)
		{
			#region arreglosBidimensionales
			string titulo="arreglo[,] recorrido  con foreach ";
			lstDatos.Items.Add(titulo);

			int[,] numeros = new int[3, 2] { {1,2}, {3, 4}, {5, 6} };
			foreach (var n in numeros)
			{
				lstDatos.Items.Add(n);
			}

			string titulo2 = "arreglo[,] recorrido  con for ";
			lstDatos.Items.Add(titulo2);
		   string[,] nombres= new string[2, 2] { {"Paola","Natalia"}, {"Carolina","Rosa"} };
		   for (int i = 0; i < nombres.GetLength(0); i++)
		   {
			   for (int j = 0; j < nombres.GetLength(1); j++)
			   {
				   lstDatos.Items.Add(nombres[i, j]);
			   }
			#endregion
		   }
		}

		private void btnClaseObjetosPropiedades_Click(object sender, EventArgs e)
		{
			#region Clases-objetos-propiedades
			ClasePrincipal cp = new ClasePrincipal();
		   
			cp.numero = 5;
			cp.mensaje = "Propiedad  de la clase tipo string";
			cp.flotante = 2.5f;
		   
			lstDatos.Items.Add("Numero que sale de la clase:"+""+cp.numero);
			lstDatos.Items.Add(cp.mensaje);
			lstDatos.Items.Add("Numero flotante que sale de la clase"+""+cp.flotante);
			#endregion
		}

		private void btnMetodos_Click(object sender, EventArgs e)
		{          
			#region MetodoConReturn
			ClaseConMetodos ccm1 = new ClaseConMetodos();
			lstDatos.Items.Add(ccm1.suma(2, 4)+" "+"<-- Metodo Con Suma");
			#endregion
		   
			#region MetodoConUsodetexboxYreturn
			ClaseConMetodos ccm2 = new ClaseConMetodos();
			try
			{
				ccm2.valor1 = int.Parse(txtValor1.Text);
				ccm2.valor2 = int.Parse(txtValor2.Text);
				lstDatos.Items.Add(ccm2.sumacontexbox(ccm2.valor1, ccm2.valor2)+""+"<--Metodo con captura  de Datos");
			}
			catch (FormatException)
			{

				MessageBox.Show("Digita los valores  en campo valor1 ,valor2,Para Usar todos los metodos completos ");
			}        
		   
			#endregion
			
			
		   #region MetodoConReferencia
			 int numero = 5456;
			 
			 ClaseConMetodos ccm3 = new ClaseConMetodos();
			 ccm3.cambiarNumero( ref numero); //hace referencia a la clase y cambia al numero del metodo           
			 lstDatos.Items.Add(numero +" "+"<-- Metodo Con Referencia");
			 #endregion
		}

		private void btnPolimorfismos_Click(object sender, EventArgs e)
		{
			#region clasescon metodos_Polimorfismos
			ClaseConPolimorfismos objPolimorfismo = new ClaseConPolimorfismos();

			lstDatos.Items.Add("Primer Mensaje" + objPolimorfismo.miVehiculo("Negro", "4", "4"));
			lstDatos.Items.Add("Mensaje es:" + objPolimorfismo.miVehiculo());
			#endregion
		}

		private void btnGet_Set_Click(object sender, EventArgs e)
		{
			#region ClaseconGetSet
			ClaseconGetSet ccgs = new ClaseconGetSet(2013);//parametro del constructor
			lstDatos.Items.Add("Tu edad es:");
			lstDatos.Items.Add(ccgs.Edad);
			lstDatos.Items.Add("El año siguiente tendras");
			ccgs.Edad = ccgs.Edad+1;
			lstDatos.Items.Add(ccgs.Edad);
			#endregion
		}

		private void btnExcepciones_Click(object sender, EventArgs e)
		{
			#region excepciones
			int[] arregloTry = { 1, 2, 3 };
			try
			{
				int x = arregloTry[3]; //esta fuera de la matriz
			}
			catch (IndexOutOfRangeException error)  //agregar + catch si se necesita mas excepciones
			{
				MessageBox.Show(error.Message);
			}
			finally 
			{
				lstDatos.Items.Add("Se ejecuto el bloque Finally"); //sigue adelante no importa la excepcion y que no exista
			}
		}
			#endregion

		private void btnHerencia_Click(object sender, EventArgs e)
		{
			#region herencia
			ClaseConHerencia cch = new ClaseConHerencia();
			 lstDatos.Items.Add(cch.MensajeyHerencia());
#endregion
		}

		private void btnEstructuras_Click(object sender, EventArgs e)
		{
		  #region estructuras
			Estructuras vector;
			vector.x = 10;
			vector.y = 20;
			vector.z = 30;
			var persona = new ClaseConEstructuraPersona();
			persona.Nombre = "Natalia";
		   
			ModificarVector(vector);        
			ModificarPersona(persona);

			lstDatos.Items.Add("el valor de X:" + vector.x + "    " + "El valor de Y:" + " " + vector.y + "  " + "El valor de Z:" + " " + vector.z);
			lstDatos.Items.Add("El Nombre es:" + persona.Nombre); 
		}
		static void ModificarPersona(ClaseConEstructuraPersona persona) 
		{
			persona.Nombre = "Pedro";                                      
		}
		static void ModificarVector(Estructuras vector)
		{
			vector.x = 0;
			vector.y = 0;
			vector.z = 0;
		  #endregion
		}

		private void BtnListas_Click(object sender, EventArgs e)
		{
			#region listas
			List<string> item = new List<string>();
			lstDatos.Items.Add("Mensaje1");
			lstDatos.Items.Add("Mensaje2");
			lstDatos.Items.Add("Mensaje3");
			foreach (string m in item)
			{
				Console.WriteLine(m);
				Console.ReadLine();
			}
#endregion
		}

		private void P_Click(object sender, EventArgs e)
		{
			#region ArrayList
			ArrayList inventario = new ArrayList();
			inventario.Add("MensajedeArraylist1");
			inventario.Add("MensajedeArraylist2");
			inventario.Add("MensajedeArraylist3");
			foreach (var mensajeArray in inventario)
			{
				lstDatos.Items.Add(mensajeArray);
			}
			#endregion

		}
	
		private void btnEnumeraciones_Click(object sender, EventArgs e)
		{
			#region enumeraciones
			frmEnum frmEnum = new frmEnum();
			frmEnum.Show();
			#endregion
		}

		private void btnBorrarDatos_Click(object sender, EventArgs e)
		{
			#region BorrarDatos
			txtValor1.Clear();
			txtValor2.Clear();
			lstDatos.Items.Clear();
			#endregion
		}

		private void BtnBaseDeDatos_Click(object sender, EventArgs e)
		{
		  
		}

		private void btnScope_Click(object sender, EventArgs e)
		{

			#region Scope
			int x = 5;
			int y = 0;
			if (x == 5)
			{
				y = 123 + 456;
			}
			lstDatos.Items.Add(y.ToString());

			#endregion
		
		}

		private void btnClasesAbstractas_Click(object sender, EventArgs e)
		{

			#region ClaseAbstracta
			var ClaseAbstractaCuadrado = new ClaseAbstractaCuadrado(4.0);

			ClaseAbstractaCuadrado.Dibujar(); //TODO revisar el mostrar el mensaje que viene de la clase abstractaCuadrado ,en modo cw
					 
			lstDatos.Items.Add("El area del cuadrado es:"+ ClaseAbstractaCuadrado.Area());
		 

			Console.ReadLine();

			#endregion
		
		}
		


		private void btnDelegado_Click(object sender, EventArgs e)
		{

			#region Delegado
			ClaseDelegadoPublicador unPublicador = new ClaseDelegadoPublicador();
			ClaseDelegadoSuscriptor unSuscriptor = new ClaseDelegadoSuscriptor();
			ClaseDelegadoSuscriptor otroSuscriptor = new ClaseDelegadoSuscriptor();

			unPublicador.EventoApublicar += new ClaseDelegadoPublicador.FirmaEventoApublicar(unSuscriptor.avisemeAqui);
			unPublicador.EventoApublicar += new ClaseDelegadoPublicador.FirmaEventoApublicar(otroSuscriptor.avisemeAqui);

			unPublicador.OcurrioEvento(txtValor1.Text);
			#endregion
	   
		}

		private void btnExcepciones_Click_1(object sender, EventArgs e)
		{


			#region Excepciones
			int a, b;
			//
			try
			{
		
				a = int.Parse (txtValor1.Text);

				b = int.Parse(txtValor2.Text);
			   
				int r = a / b;

			   lstDatos.Items.Add(r);
			}
			catch (FormatException)
			{

				lstDatos.Items.Add("No es un número válido");
		 
				// Salimos de la función, pero se ejecutará el finally
				return;
			}
			catch (DivideByZeroException)
			{
				lstDatos.Items.Add("La división por cero no está permitida");

			}
			catch (Exception ex)
			{
				// Captura del resto de excepciones
				Console.WriteLine(ex.Message);
			}
			finally
			{
				// Este código siempre se ejecutará
				MessageBox.Show("Siempre Me ejecuto");
			}

			#endregion

		}

		private void btnConsultarXml_Click(object sender, EventArgs e)
		{
			    CrearXml();
		}

		#region crearXml
		private void CrearXml()
		{

			XmlDocument doc = new XmlDocument();
			XmlElement raiz = doc.CreateElement("libros");
			doc.AppendChild(raiz);

			XmlElement libro = doc.CreateElement("libro");
			raiz.AppendChild(libro);

			XmlElement titulo = doc.CreateElement("titulo");
			titulo.AppendChild(doc.CreateTextNode("El Hobbit"));
			libro.AppendChild(titulo);

			XmlElement precio = doc.CreateElement("Precio");
			precio.AppendChild(doc.CreateTextNode("100000"));
			libro.AppendChild(precio);

			doc.Save(@"C:\Users\AndreuDekker\Documents\Xml\archivo.xml");

		}

#endregion



	   

	
	
	}
}
