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

namespace demo03_mantenimiento
{
    public partial class frmEditarProductos : Form
    {
        public frmEditarProductos()
        {
            InitializeComponent();
        }

        SqlConnection Cn = new SqlConnection(demo03_mantenimiento.Properties.Settings.Default.NWCN);
        private void frmEditarProductos_Load(object sender, EventArgs e)
        {
            SqlDataAdapter dap = new SqlDataAdapter("usp_listarProductos", Cn);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tblProductos = new DataTable();
            dap.Fill(tblProductos);
            dgvProductos.DataSource = tblProductos;



            }
         

        private void btnActualizarProductos_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("usp_ActualizarProducto", Cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("codigo", txtCodigo.Text);
            cmd.Parameters.AddWithValue("nombre", TxtNombre.Text);
            cmd.Parameters.AddWithValue("precio", txtPrecio.Text);
            cmd.Parameters.AddWithValue("stock", txtStock.Text);
            Cn.Open();
            int filas=cmd.ExecuteNonQuery();
            Cn.Close();
            if (filas !=0)
            {
                MessageBox.Show("El registro se ha actualizado correctamente");
                //txtCodigo.Text = string.Empty;
                //TxtNombre.Text = string.Empty;
                //txtPrecio.Text = string.Empty;
                //txtStock.Text = string.Empty;
                //frmEditarProductos_Load(null, null);
                //limpiarControles();
                dgvProductos.FirstDisplayedScrollingRowIndex = posicion;
            }
        }

        public int posicion =0;
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            posicion=e.RowIndex;
            DataGridViewRow fila = dgvProductos.Rows[posicion];
            
            txtCodigo.Text = fila.Cells[0].Value.ToString();
           TxtNombre.Text = fila.Cells[1].Value.ToString();
           txtPrecio.Text = fila.Cells[2].Value.ToString();
           txtStock.Text = fila.Cells[3].Value.ToString();
        }

        //public void limpiarControles()
        //{
         
            
        //    //foreach (Control ctrl in this.Controls)
        //    //{
        //    //    if (Control is TextBox)
        //    //    {
        //    //        ctrl.Text = string.Empty;
        //    //    }
        //    }
        }
    }
