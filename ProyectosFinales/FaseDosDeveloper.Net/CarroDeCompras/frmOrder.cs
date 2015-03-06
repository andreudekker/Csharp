using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace CarroDeCompras
{
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(CarroDeCompras.Properties.Settings.Default.Nwcn);
        private void frmOrder_Load(object sender, EventArgs e)
        {
            #region LLENADO DE TXT,COMBO,DGV
            
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            SqlCommand cmd = new SqlCommand("usp_llenarcombos", cn);
            cmd.Connection.Open();

            SqlDataReader lector = cmd.ExecuteReader();
            BindingSource bsCliente = new BindingSource();
            bsCliente.DataSource = lector;
            cboCliente.DataSource = bsCliente;
            cboCliente.DisplayMember="CompanyName";
            cboCliente.ValueMember = "CustomerID"; 

            lector.NextResult();
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
            #endregion


        #region LLENADO DATOS GRID
        
        private void dgvProducto_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvProducto.CurrentCell.ColumnIndex==1) //puntero al cbo
            {
                DataGridViewComboBoxEditingControl cboProducto =(DataGridViewComboBoxEditingControl)e.Control;
                cboProducto.SelectionChangeCommitted += new EventHandler(cboProducto_SelectionChangeCommitted);

            }
            if (dgvProducto.CurrentCell.ColumnIndex==3)
            {
                DataGridViewTextBoxEditingControl txtCantidad = (DataGridViewTextBoxEditingControl)e.Control;
                txtCantidad.KeyPress += new KeyPressEventHandler(txtCantidad_KeyPress);
                txtCantidad.TextChanged += new EventHandler(txtCantidad_TextChanged);
            }

        }
        #endregion

        #region VALIDACION CAMPOS GRID
        
        int Stock = 0;

        void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            DataGridViewTextBoxEditingControl txtCantidad = (DataGridViewTextBoxEditingControl)sender;
            if (txtCantidad.Text !=string.Empty)
            {
                int cantidad = int.Parse(txtCantidad.Text);

                esValidoCantidad = (cantidad <= Stock);
               
            }
        }
        #endregion
        
        #region Validacion campos Int&String
        void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled=!(Char.IsDigit(e.KeyChar))|| ((int)e.KeyChar)==8;
        }
        #endregion

        #region Consultayllenadodeldgv
        void cboProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataGridViewComboBoxEditingControl cboProducto = (DataGridViewComboBoxEditingControl)sender;
            
            SqlCommand cmd = new SqlCommand("usp_productoxcodigo", cn);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Codigo", cboProducto.SelectedValue);
            cn.Open();
            SqlDataReader lector = cmd.ExecuteReader(CommandBehavior.SingleRow);
            if (lector.HasRows)
            {
                lector.Read();
                DataGridViewRow fila=dgvProducto.CurrentRow;
                fila.Cells[0].Value = cboProducto.SelectedValue;
                fila.Cells[2].Value=lector.GetDecimal(lector.GetOrdinal("UnitPrice"));
                Stock=lector.GetInt16(lector.GetOrdinal("UnitsInStock"));
                lector.Close();
            }
            cn.Close();
        }
        #endregion

        #region VALIDACION DE LOS CAMPOS GRID
        
        bool esValidoCantidad = true;
        private void dgvProducto_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (!esValidoCantidad)
            {
                    e.Cancel = true;
                    dgvProducto.CurrentRow.ErrorText = "La cantidad ingresada supera el Stock"+Stock.ToString();
            }
            else
	            {
                    e.Cancel = false;
                    dgvProducto.CurrentRow.ErrorText = string.Empty;
	            }
    
        }
        #endregion

        #region grabar datos con bd-TRANSACCIONES
        private void btnGrabar_Click(object sender, EventArgs e)
        {

            bool operacionExitosa = true;
            int OrderID=0;
            //grabar en la cabecera
            

            string strCustomerID = cboCliente.SelectedValue.ToString();
            int intCodigoEmpleado = Convert.ToInt32(cboEmpleado.SelectedValue);
            string strShipAddress = txtDireccion.Text;

            SqlCommand cmdOrden = new SqlCommand("usp_generarOrden", cn);
            cmdOrden.CommandType = CommandType.StoredProcedure;
            
            cmdOrden.Parameters.AddWithValue("CustomerID",strCustomerID);
            cmdOrden.Parameters.AddWithValue("EmployeeID",intCodigoEmpleado);
            cmdOrden.Parameters.AddWithValue("ShipAddress",strShipAddress);
            
            cmdOrden.Parameters.AddWithValue("OrderID", 0);
            cmdOrden.Parameters["OrderID"].Direction = ParameterDirection.Output;


            int filas = 0;
            try
            {
                //transacciones

                cn.Open();
                SqlTransaction tx = cn.BeginTransaction();//Variable tx
                cmdOrden.Transaction = tx;
                filas = cmdOrden.ExecuteNonQuery();
                if (filas !=0)
                {
                    OrderID = Convert.ToInt32(cmdOrden.Parameters["OrderID"].Value);
                    SqlCommand CmdDetalle = new SqlCommand("usp_grabar_detalle", cn);
                    CmdDetalle.CommandType = CommandType.StoredProcedure;
                    CmdDetalle.Transaction = tx;
                    CmdDetalle.Parameters.Add(new SqlParameter("OrderID",SqlDbType.Int,4));
                    CmdDetalle.Parameters.Add(new SqlParameter("ProductID",SqlDbType.Int,4));
                    CmdDetalle.Parameters.Add(new SqlParameter("UnitPrice", SqlDbType.Money));
                    CmdDetalle.Parameters.Add(new SqlParameter("Quantity",SqlDbType.Int,4));

                    SqlCommand cmdActualizarProducto = new SqlCommand("usp_actualizar_producto", cn);
                    cmdActualizarProducto.CommandType = CommandType.StoredProcedure;
                    cmdActualizarProducto.Transaction = tx;
                    cmdActualizarProducto.Parameters.Add(new SqlParameter("ProductID", SqlDbType.Int, 4));
                    cmdActualizarProducto.Parameters.Add(new SqlParameter("Quantity", SqlDbType.Int, 4));

                    foreach (DataGridViewRow item in dgvProducto.Rows)  //recorre el datagridView --Graba detalle
                    {
                        if (item.Cells[0].Value != null)
                        {
                            int codigoProducto = Convert.ToInt32(item.Cells[0].Value);
                            decimal Precio = Convert.ToDecimal(item.Cells[2].Value);
                            int Cantidad = Convert.ToInt32(item.Cells[3].Value);
                            
                            CmdDetalle.Parameters["OrderID"].Value=OrderID;
                            CmdDetalle.Parameters["ProductID"].Value = codigoProducto;
                            CmdDetalle.Parameters["UnitPrice"].Value = Precio;
                            CmdDetalle.Parameters["Quantity"].Value = Cantidad;

                            filas=CmdDetalle.ExecuteNonQuery();
                            if (filas!=0)
                            {
                                //Actualizar Stock
                                cmdActualizarProducto.Parameters["ProductID"].Value = codigoProducto;
                                cmdActualizarProducto.Parameters["Quantity"].Value = codigoProducto;
                                cmdActualizarProducto.ExecuteNonQuery();
                                if (filas !=0)
                                {
                                    operacionExitosa = true;
                                }
                                else
                                {
                                    operacionExitosa = false;
                                    return;
                                }
                            }
                            else
                            {
                                operacionExitosa = false;
                                return;
                            }
                        }

                    }
                }
                cn.Close();
                
                if (operacionExitosa==true)
                {
                    tx.Commit();
                    MessageBox.Show("Orden Creada OK","Developer");
                    txtNumeroDelaOrden.Text = cmdOrden.Parameters["OrderID"].Value.ToString();

                }
                
                    tx.Rollback();
                
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);

            }
            finally
            {

                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close(); 
                }
            }










        }

        #endregion

    }
}
