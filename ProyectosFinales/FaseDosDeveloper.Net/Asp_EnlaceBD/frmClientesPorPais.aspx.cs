using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Asp_EnlaceBD
{
    public partial class frmClientesPorPais : System.Web.UI.Page
    {

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NWCN"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if ( ! IsPostBack)
            {
                SqlCommand cmd = new SqlCommand("USP_LISTARPAISES",cn);
                cmd.CommandType =CommandType.StoredProcedure;
                SqlDataAdapter dap = new SqlDataAdapter(cmd);
                DataTable tblPaises = new DataTable();
                dap.Fill(tblPaises);

                DdlPaises.DataSource = tblPaises;
                DdlPaises.DataTextField = "Country";
                DdlPaises.DataValueField = "Country";
                DdlPaises.DataBind();

            }



         
        }

        protected void DdlPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strPais = DdlPaises.SelectedItem.Text;
            SqlCommand cmd = new SqlCommand("USP_CLIENTESPORPAIS", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Pais", strPais);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable tblClientes = new DataTable();
            dap.Fill(tblClientes);

            gvClientes.DataSource = tblClientes;
            gvClientes.DataBind();


        }
    }
}