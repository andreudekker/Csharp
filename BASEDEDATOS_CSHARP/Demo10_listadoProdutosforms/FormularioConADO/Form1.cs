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

namespace FormularioConADO
{
    public partial class FrmListarProductos : Form
    {
        public FrmListarProductos()
        {
            InitializeComponent();
        }
        SqlConnection Cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NWCN"].ConnectionString);
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            //SqlDataAdapter dap = new SqlDataAdapter("usp_listarProductos", Cn);
            //dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            SqlCommand cmd = new SqlCommand("usp_listarProductos", Cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable tblproductos = new DataTable();
            dap.Fill(tblproductos);
            dgvProductos.DataSource = tblproductos;
        }
    }
}
