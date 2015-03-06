using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using System.Configuration;
using System.Data.SqlClient;
namespace SistemaCsharp_Pitbullnet
{
	public partial class frmLinq : Form
	{
		public frmLinq()
		{
			InitializeComponent();
		}
		
		

		

			
		
		private void BtnLinqConsultarArray_Click(object sender, EventArgs e)
		{
			
			   # region consultarLinqUnArray
			
			int[] numeros = { 1, 3, 5, 7, 9, 11, 13 };

	
			var consultarNumeros = from  cnumero in numeros
												orderby   cnumero descending
												where cnumero >3
												select  cnumero;

			foreach (var cnumero in numeros)
			{
				lstDatosLinq.Items.Add(cnumero);

			}
#endregion

		}

		private void btnConsultarUnArraylist_Click(object sender, EventArgs e)
		{

			  #region consultaLinqdeunArray
			ArrayList MensajeDeSaludo= new ArrayList();
				MensajeDeSaludo.Add("Hola");
				MensajeDeSaludo.Add("Hola2");
				MensajeDeSaludo.Add("Hola3");

				var consulta = from string Ms in MensajeDeSaludo
								   where  Ms == "Hola2"
									select Ms;
			foreach (string m in consulta)

				{
							lstDatosLinq.Items.Add(m);
				}

			#endregion

		}

		private void btnConsultarLista_Click(object sender, EventArgs e)
		{


				#region consultadelinqdeunalista
			List<int> listanumeros = new List<int>();
			listanumeros.Add(456);
			listanumeros.Add(951);
			listanumeros.Add(6523);
			var consultanumeros = from int numero in listanumeros                                            
											   select numero;
			foreach (int n in listanumeros)
			{
				lstDatosLinq.Items.Add(n);
			}
			#endregion


		}

	
		
		
		private void btnConsultarXML_Linq_Click(object sender, EventArgs e)
		{


			#region ConsultaXmlconLinq
			XElement xmlContactos = XElement.Load(@"C:\Users\AndreuDekker\Documents\Xml\archivo.xml");
			var obtenerXml = from libros in xmlContactos.Descendants("libro")
									  select libros.Element("titulo").Value;
			foreach (var li in obtenerXml)
			{
				lstDatosLinq.Items.Add(li);
			}
			#endregion

		}

		private void btnConsultarSqlServer_Click(object sender, EventArgs e)
		{
			
			
			ConexionLinqDataContext db = new ConexionLinqDataContext();


			#region ConsultaBasicaASqlserver
			var consultarSql = from us in  db.Usuarios
										where us.nombre =="andreu"
										select us;

		 

			foreach (var usu in consultarSql)
			{
				lstDatosLinq.Items.Add(usu.nombre);

			}
			#endregion
		}

		private void frmLinq_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'empresadePruebaDataSet.Usuario' table. You can move, or remove it, as needed.
			this.usuarioTableAdapter.Fill(this.empresadePruebaDataSet.Usuario);
			
			ClaseCrudLinq objMostrar = new ClaseCrudLinq();

			#region cargarDatosConConsultaLinq
			try
			{
				objMostrar.mostrar(cboBuscarLinq);
			}
			catch (Exception error)
			{
				MessageBox.Show(error.Message.ToString());

			}
			#endregion
		}

		private void btnLimpiarDatos_Click(object sender, EventArgs e)
		{
			lstDatosLinq.Items.Clear();
		}

		private void btnGrabar_Click(object sender, EventArgs e)
		{

			ClaseCrudLinq objGuardar = new ClaseCrudLinq();

			#region GuardarCambiosSqlconLinq
			try
			{
				objGuardar.guardar(txtNombreLinq.Text, txtTelefonoLinq.Text);
			}
			catch (Exception error)
			{
				MessageBox.Show(error.Message.ToString());

			}
			#endregion 
		}

		private void btnMostrarLinq_Click(object sender, EventArgs e)
		{

			ClaseCrudLinq objMostrar = new ClaseCrudLinq();

			#region MostrarDatos
			try
			{
				objMostrar.mostrar(lstDatosLinq);
			}
			catch (Exception error)
			{

				MessageBox.Show(error.Message.ToString());
			}
			#endregion
		}

		private void btnCargar_Click(object sender, EventArgs e)
		{

			ClaseCrudLinq objCargar = new ClaseCrudLinq();
			#region CargarlosDatosconlinq
			try
			{
				objCargar.cargar(cboBuscarLinq.Text,txtNombreLinq,txtTelefonoLinq);
			}
			catch (Exception error)
			{

				MessageBox.Show(error.Message.ToString());
			}

			#endregion

		}

		private void btnEditarLinq_Click(object sender, EventArgs e)
		{
			ClaseCrudLinq objModificar = new ClaseCrudLinq();

			#region ModificarLosDatosConLinq
			try
			{
				objModificar.modificar(txtNombreLinq.Text, txtTelefonoLinq.Text, cboBuscarLinq.Text);
				MessageBox.Show("Modificado Exitosamente");
			}
			catch (Exception error)
			{

				MessageBox.Show(error.Message.ToString());
			}
			#endregion

		}

		private void BtnBorrarSQL_Click(object sender, EventArgs e)
		{
			ClaseCrudLinq objBorrar = new ClaseCrudLinq();

			#region BorrarlosDatosLinq
			try
			{
				//seleccionar el listBox con el elemento para borrarlo

				objBorrar.Eliminar(lstDatosLinq.SelectedItem.ToString());
				MessageBox.Show("Alerta", " Desea Continuar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
			}
			catch (Exception error)
			{

				MessageBox.Show(error.Message.ToString());
			}
			#endregion
		}

  

	


	   

	  
		
		
			
	}
}//fin del Main
