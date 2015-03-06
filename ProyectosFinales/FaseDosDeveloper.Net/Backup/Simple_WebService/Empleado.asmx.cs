using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace Simple_WebService
{
    /// <summary>
    /// Summary description for Empleado
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Empleado : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public DataSet listarEmpleados()
        {
            using (SqlConnection cn = new SqlConnection("Server=.;DataBase=Northwind;Integrated Security=true"))
            {
                SqlDataAdapter dap = new SqlDataAdapter("select employeeID,firstName,title from employees", cn);
                DataSet ds = new DataSet();
                dap.Fill(ds);
                return ds;
            }
       }
    }
}
