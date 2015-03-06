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

namespace registroProducto_consqlserver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NWCN"].ConnectionString);
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter dap = new SqlDataAdapter("usp_listarcategorias", Cn);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable tblCategorias = new DataTable();
            dap.Fill(tblCategorias);
            CboCatagorias.DataSource = tblCategorias;
            CboCatagorias.DisplayMember = "CategoryName";
            CboCatagorias.ValueMember = "CategoryID";


        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("usp_RegistrarProductos", Cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Nombre",txtNombre.Text);
            cmd.Parameters.AddWithValue("Categoria", CboCatagorias.SelectedValue);
            cmd.Parameters.AddWithValue("Precio", txtPrecio.Text);
            cmd.Parameters.AddWithValue("Stock", txtStock.Text);
            cmd.Parameters.AddWithValue("Codigo", 0);
            cmd.Parameters["codigo"].Direction = ParameterDirection.Output;
            Cn.Open();
             int fila=cmd.ExecuteNonQuery();
            Cn.Close();
            if (fila !=0)
            {
                MessageBox.Show("Se registro correctamente");
                txtNombre.Text = string.Empty;
                txtPrecio.Text = string.Empty;
                txtStock.Text = string.Empty;
                CboCatagorias.SelectedIndex = 0;
                txtCodigo.Text = cmd.Parameters["codigo"].Value.ToString();
            }

        }
    }
}
