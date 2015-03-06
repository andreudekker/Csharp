using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CarritoCompras
{
	public partial class frmOrders : Form
	{
		public frmOrders()
		{
			InitializeComponent();
		}

		SqlConnection Cn = new SqlConnection(CarritoCompras.Properties.Settings.Default.NWCN);
		private void frmOrders_Load(object sender, EventArgs e)
		{
			txtFechaOrden.Text = DateTime.Now.ToString("dd/MM/yyyy");
			SqlCommand cmd = new SqlCommand("usp_llenarcombos", Cn);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Connection.Open();
			SqlDataReader lector = cmd.ExecuteReader();

			BindingSource bsCliente = new BindingSource();
			bsCliente.DataSource = lector;
			cboCliente.DataSource = bsCliente;
			cboCliente.DisplayMember = "CompanyName";
			cboCliente.ValueMember = "CustomerID";

			lector.NextResult();   /*consulta el siguiente select del store*/

			BindingSource bsEmpleado = new BindingSource();
			bsEmpleado.DataSource = lector;
			cboEmpleado.DataSource = bsEmpleado;
			cboEmpleado.DisplayMember = "LastName";
			cboEmpleado.ValueMember = "EmployeeID";

			lector.NextResult();
			BindingSource bsProducto = new BindingSource();
			bsProducto.DataSource = lector;

			cboProducto.DataSource = bsProducto;
			cboProducto.DisplayMember = "ProductName";
			cboProducto.ValueMember = "ProductID";

			cmd.Connection.Close();
		}

		private void dgvProductos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			if (dgvProductos.CurrentCell.ColumnIndex == 1)
			{
				DataGridViewComboBoxEditingControl cboProducto = (DataGridViewComboBoxEditingControl)e.Control;
				cboProducto.SelectionChangeCommitted += new EventHandler(cboProducto_SelectionChangeCommitted);
			}
			if (dgvProductos.CurrentCell.ColumnIndex == 3)
			{
				DataGridViewTextBoxEditingControl txtCantidad = (DataGridViewTextBoxEditingControl)e.Control;
				txtCantidad.KeyPress += new KeyPressEventHandler(txtCantidad_KeyPress);
				txtCantidad.TextChanged += new EventHandler(txtCantidad_TextChanged);
			}
		}

		void txtCantidad_TextChanged(object sender, EventArgs e)
		{
			DataGridViewTextBoxEditingControl txtCantidd = (DataGridViewTextBoxEditingControl)sender;
			if (txtCantidd.Text != string.Empty)
			{
				if (txtCantidd.Text != string.Empty)
				{
					int Cantidad = int.Parse(txtCantidd.Text);
					esValidoCantidad = (Cantidad <= Stock);

				}
			}
		}

		void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(Char.IsDigit(e.KeyChar) || ((int)e.KeyChar) == 8);
		}


		int Stock = 0;
		void cboProducto_SelectionChangeCommitted(object sender, EventArgs e)
		{
			DataGridViewComboBoxEditingControl cboProducto = (DataGridViewComboBoxEditingControl)sender;
			//MessageBox.Show(cboProducto.SelectedValue.ToString());
			SqlCommand cmd = new SqlCommand("usp_productoxcodigo", Cn);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("Codigo", cboProducto.SelectedValue);
			Cn.Open();
			SqlDataReader lector = cmd.ExecuteReader(CommandBehavior.SingleRow);
			if (lector.HasRows)
			{
				lector.Read();
				DataGridViewRow fila = dgvProductos.CurrentRow;
				fila.Cells[0].Value = cboProducto.SelectedValue;
				fila.Cells[2].Value = lector.GetDecimal(lector.GetOrdinal("UnitPrice"));
				Stock = lector.GetInt16(lector.GetOrdinal("UnitsInStock"));
				lector.Close();
			}
			Cn.Close();


		}
		bool esValidoCantidad = true;
		private void dgvProductos_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			if (!esValidoCantidad)
			{
				e.Cancel = true;
				dgvProductos.CurrentRow.ErrorText = "La cantidad ingresada supera el stock" + Stock.ToString();
			}
			else
			{
				e.Cancel = false;
				dgvProductos.CurrentRow.ErrorText = string.Empty;

			}

		}

		private void btnGrabar_Click(object sender, EventArgs e)
		{
			
			
			bool operacionExitosa= true;
			int  intorderID= 0;
			
			string strCustomerID=cboCliente.SelectedValue.ToString();
			int intCodigoEmpleado = Convert.ToInt32(cboEmpleado.SelectedValue);
			string strShipAddress = txtDireccion.Text;

			SqlCommand cmdOrden = new SqlCommand("usp_generarOrden",Cn);
			cmdOrden.CommandType= CommandType.StoredProcedure;
			
			 cmdOrden.Parameters.AddWithValue("CustomerID",strCustomerID);
			 cmdOrden.Parameters.AddWithValue("EmployeeID",intCodigoEmpleado);
			 cmdOrden.Parameters.AddWithValue("Address",strShipAddress);
			 cmdOrden.Parameters.AddWithValue("OrderID",0);
			 cmdOrden.Parameters["OrderID"].Direction=ParameterDirection.Output;
		   
			 int filas =0;
			try 
			{	        
					   Cn.Open();   
						SqlTransaction  tx = Cn.BeginTransaction();
					   cmdOrden.Transaction=tx;
						filas=cmdOrden.ExecuteNonQuery();
					   
					if (filas !=0)
					{
						   intorderID= Convert.ToInt32( cmdOrden.Parameters["OrderID"].Value);
							SqlCommand cmdDetalle = new SqlCommand("usp_grabar_detalle",Cn);
							cmdDetalle.CommandType=CommandType.StoredProcedure;
							cmdDetalle.Transaction=tx;
							
							cmdDetalle.Parameters.Add(new SqlParameter("OrderID",SqlDbType.Int,4));
							cmdDetalle.Parameters.Add(new SqlParameter("ProductID",SqlDbType.Int,4));
							 cmdDetalle.Parameters.Add(new SqlParameter("UnitPrice",SqlDbType.Money)); 
							cmdDetalle.Parameters.Add(new SqlParameter("Quantity",SqlDbType.Int,4));
							  SqlCommand cmdActualizarProducto = new SqlCommand("usp_actualizar_producto",Cn);
								cmdActualizarProducto.CommandType= CommandType.StoredProcedure;
								 cmdActualizarProducto.Transaction= tx;
								 cmdActualizarProducto.Parameters.Add(new SqlParameter("ProductID",SqlDbType.Int,4));
								 cmdActualizarProducto.Parameters.Add(new SqlParameter("Quantity",SqlDbType.Int,4));
									
								  

									  foreach (DataGridViewRow item in dgvProductos.Rows)
										{
												if (item.Cells[0].Value !=null)
												{
													int CodigoProducto = Convert.ToInt32(item.Cells[0].Value);
													decimal Precio=Convert.ToDecimal(item.Cells[2].Value);
													 int Cantidad=Convert.ToInt32(item.Cells[3].Value);

													cmdDetalle.Parameters["OrderID"].Value=intorderID;
													 cmdDetalle.Parameters["ProductID"].Value=CodigoProducto;
													 cmdDetalle.Parameters["UnitPrice"].Value=Precio;
													 cmdDetalle.Parameters["Quantity"].Value=Cantidad;
													filas= cmdDetalle.ExecuteNonQuery();
													if (filas !=0)
															{
																cmdActualizarProducto.Parameters["ProductID"].Value=CodigoProducto;
															  cmdActualizarProducto.Parameters["Quantity"].Value=Cantidad;
																filas = cmdActualizarProducto.ExecuteNonQuery();
																if (filas !=0)
																{
																			operacionExitosa= true;
																				
																}
																else
																{
																		operacionExitosa=false;
																			return;
																}
																
															}
													else
													{
														operacionExitosa=false;
														return;
													}
												}   
							
										 }
								   }
								   
										 if (operacionExitosa)
											{
													tx.Commit();
													MessageBox.Show("OrdenCreada Ok","Programa de prueba");
													txtNumeroOrden.Text=cmdOrden.Parameters["OrderID"].Value.ToString();
											}   
										 else
										 {
												tx.Rollback();
										 }      
			  
				catch (Exception ex)
						{
								 MessageBox.Show("Ocurrio un error",ex.Message);
						}    
				finally
						{
							 if (Cn.State !=ConnectionState.Closed)
									{
										 Cn.Close();
									}    
						}          
			
