using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;



namespace CombosAnidadosWinFormyAsp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection("Server=.;DataBase=Northwind;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter dap = new SqlDataAdapter("SELECT DISTINCT country FROM customers",cn);
            DataTable tbl= new DataTable();
            dap.Fill(tbl);
            DataRow dr = tbl.NewRow();
            dr["Country"] = "Seleccione";
            tbl.Rows.InsertAt(dr, 0);
            cboPais.DataSource = tbl;
            cboPais.DisplayMember = "Country";
            cboPais.ValueMember = "Country";
        }

        private void cboPais_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SqlDataAdapter dap = new SqlDataAdapter("SELECT CustomerID,CompanyName  FROM customers WHERE country = @Country", cn);
            dap.SelectCommand.Parameters.AddWithValue("Country", cboPais.Text);
            
            DataTable tbl = new DataTable();
            dap.Fill(tbl);
            
            DataRow dr = tbl.NewRow();
            dr["CustomerID"] = "00000";
            dr["CompanyName"] = "Seleccione";
            tbl.Rows.InsertAt(dr, 0);
           
            cboCliente.DataSource = tbl;
            cboCliente.DisplayMember = "CompanyName";
            cboCliente.ValueMember = "CustomerID";
        }

        private void cboCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {

            SqlDataAdapter dap = new SqlDataAdapter("SELECT OrderID  FROM orders WHERE CustomerID= @Codigo", cn);
            dap.SelectCommand.Parameters.AddWithValue("Codigo", cboCliente.SelectedValue);

            DataTable tbl = new DataTable();
            dap.Fill(tbl);

            

            cboOrden.DataSource = tbl;
            cboOrden.DisplayMember = "OrderID";
            cboOrden.ValueMember = "OrderID";
        }
    }
}
