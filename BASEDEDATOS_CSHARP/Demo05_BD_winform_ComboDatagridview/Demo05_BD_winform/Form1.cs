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


namespace Demo05_BD_winform
{
    public partial class Form1 : Form
    {

        SqlConnection Cn =null;
        public Form1()
        {
            InitializeComponent();
            string strConexion = ConfigurationManager.ConnectionStrings["NwCn"].ConnectionString;
            Cn = new SqlConnection(strConexion);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            

            try
            {
                Cn.Open();
                DataTable tbltablas = Cn.GetSchema("Tables");
                DataView dv = tbltablas.AsDataView();
                dv.RowFilter = "TABLE_TYPE='BASE TABLE'";
                dv.Sort = "Table_Name ASC";
                tbltablas = dv.ToTable();
                CboTabla.DataSource = tbltablas;
                CboTabla.DisplayMember = "TABLE_NAME";
                Cn.Close();

            }
            catch (SqlException Sqlex)
            {
                MessageBox.Show("Ocurrio un Error SQL" + Sqlex.Message);

            }
            catch (NullReferenceException Nullex)
            {
                MessageBox.Show("Ocurrio un Error NULL" + Nullex.Message);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error Exception" + ex.Message);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
                 SqlDataAdapter dap = new SqlDataAdapter("usp_MostrarInformacion", Cn);
                dap.SelectCommand.CommandType=CommandType.StoredProcedure;    
                dap.SelectCommand.Parameters.AddWithValue("Tabla",CboTabla.Text);
                DataTable tbl = new DataTable();
                dap.Fill(tbl);
                dgvTabla.DataSource=tbl;
               
        }
    }
}
