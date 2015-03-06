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

namespace ConexionConBDCompleto
{
    public partial class frmProducto : Form
    {
    SqlConnection cn = new SqlConnection(ConexionConBDCompleto.Properties.Settings.Default.NwCn);  //Conexion setting

        public frmProducto()
        {
            InitializeComponent();
        }
        BindingSource bs = new BindingSource();
   
        private void frmProducto_Load(object sender, EventArgs e)
        {
            
         
            #region Conexion
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter("usp_Mdatos", cn);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            ds.Clear();
            dap.Fill(ds);
        
            dgvProductos.DataSource = ds.Tables[0];
            bs.DataSource = ds.Tables[0];

            txtIdproducto.DataBindings.Add(new Binding("Text", bs, "IDProducto"));
            txtDescripcion.DataBindings.Add(new Binding("Text", bs, "Descripcion"));
            txtPrecio.DataBindings.Add(new Binding("Text", bs, "Precio"));
            txtStock.DataBindings.Add(new Binding("Text", bs, "Stock"));
            txtNotas.DataBindings.Add(new Binding("Text", bs, "Notas"));
            #endregion

        }
        #region Botones de desplazamiento
        private void btnVaalPrimero_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
        }
        #endregion
       
        #region  Limpiar Campos
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarControles();
        }
        #endregion

        #region Posicion DataGrid
        public int posicion = 0; //posicion de la tabla en el formulario
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
            posicion = e.RowIndex;   //asigno la posicion
            DataGridViewRow fila = dgvProductos.Rows[posicion];
            //txtIdproducto.Text = fila.Cells[0].Value.ToString();
            txtDescripcion.Text = fila.Cells[1].Value.ToString();//desplazarme con el mouse por las celdas
            txtStock.Text = fila.Cells[2].Value.ToString();
            txtPrecio.Text = fila.Cells[3].Value.ToString();
            txtNotas.Text = fila.Cells[3].Value.ToString();
        }
        #endregion

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            #region pruebadeinsercionde datos
            SqlCommand cmd = new SqlCommand("uspIdatos_", cn);
            cmd.CommandType = CommandType.StoredProcedure;
           
            cmd.Parameters.AddWithValue("IDProducto", txtDescripcion.Text);
            cmd.Parameters.AddWithValue("Descripcion", txtDescripcion.Text);
            cmd.Parameters.AddWithValue("Precio", txtPrecio.Text);
            cmd.Parameters.AddWithValue("Stock", txtStock.Text);
            cmd.Parameters.AddWithValue("Notas", txtNotas.Text);

            cn.Open();

            int filas = cmd.ExecuteNonQuery();
            cn.Close();
            if (filas != 0)
            {
                MessageBox.Show("El producto fue actualizado correctamente");
                limpiarControles();

            }
            frmProducto_Load(null, null); ///actualiza los registros del datagrid
            dgvProductos.FirstDisplayedScrollingColumnIndex = posicion; //organizar el datagrid view al momento de guardar los datos     
            #endregion

            


        }
          
       
        #region Funcion limpiarControles
        public void limpiarControles()
        {
            foreach (Control ctrl in this.Controls)      //this hace referencia al formulario--recorremos los controles del formulario
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = String.Empty;
                }
            }
        }
        #endregion



    }
}
