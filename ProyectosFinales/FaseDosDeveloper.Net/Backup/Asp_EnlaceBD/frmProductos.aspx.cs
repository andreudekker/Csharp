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
    public partial class frmProductos : System.Web.UI.Page
    {

        
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NWCN"].ConnectionString);
            SqlDataAdapter dap = new SqlDataAdapter("usp_listarProductos",cn);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tblProducto = new DataTable();
            dap.Fill(tblProducto);
            dgProductos.DataSource = tblProducto;
            dgProductos.DataBind();

      
        }
    }
}