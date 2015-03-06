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
    public partial class frmFotoEmpleado : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NWCN"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (! IsPostBack)
            {
                SqlDataAdapter dap = new SqlDataAdapter("USP_LISTAREMPLEADOS_", cn);
                dap.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable tblEmpleado = new DataTable();
                dap.Fill(tblEmpleado);
                ddlEmpleado.DataSource = tblEmpleado;
                ddlEmpleado.DataTextField = "LastName";
                ddlEmpleado.DataValueField = "EmployeeID";
                ddlEmpleado.DataBind();

            }


            
        
        }

        protected void ddlEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            imgEmpleado.ImageUrl = "ProcesarFoto2.ashx?codigo=" + ddlEmpleado.SelectedValue.ToString();
        }
    }
}