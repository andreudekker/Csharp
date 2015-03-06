using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Asp_EnlaceBD
{
    /// <summary>
    /// Summary description for ProcesarFoto2
    /// </summary>
    public class ProcesarFoto2 : IHttpHandler
    {
        //Archivo GenericHandler
        public void ProcessRequest(HttpContext context)
        {
            int codigoEmpleado = int.Parse(context.Request.QueryString["Codigo"]);
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["NWCN"].ConnectionString);
            SqlCommand cmd = new SqlCommand("usp_MostrarFotoEmpleado", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Codigo",codigoEmpleado);
            cn.Open();

            byte[] foto = (byte[])cmd.ExecuteScalar();
            cn.Close();

            context.Response.ContentType = "Image/jpg";
            context.Response.OutputStream.Write(foto, 78, foto.Length - 78);


        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}