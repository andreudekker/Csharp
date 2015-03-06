using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Asp_EnlaceBD
{
    public partial class frmLeerunXML : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGenerarXML_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NWCN"].ConnectionString);
            SqlDataAdapter dap = new SqlDataAdapter("Select ProductID,ProductName,UnitPrice,UnitsinStock from products",cn);
            dap.SelectCommand.CommandType = CommandType.Text;
            DataSet dsProductos = new DataSet("Productos");
            dap.Fill(dsProductos);
            dsProductos.Tables[0].TableName = "Producto";
            dsProductos.Tables[0].Columns["ProductID"].ColumnMapping = MappingType.Attribute;
            dsProductos.WriteXml(Server.MapPath("XML/productos.Xml")); //al folder XML

            

        }

        protected void btnLeerXML_Click(object sender, EventArgs e)
        {
            DataSet dsProductos= new DataSet();
            dsProductos.ReadXml(Server.MapPath("XML/productos.Xml"));
            gvProductos.DataSource = dsProductos;
            gvProductos.DataBind();

        }
    }
}