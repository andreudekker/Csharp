using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ConexionBD_con_Interface
{
    class Productos:Idata
    {

        SqlConnection cn = new SqlConnection("Server=.;DataBase=Northwind;Integrated Security=true");
       
        public System.Data.DataSet Listar()
        {
            SqlDataAdapter dap = new SqlDataAdapter("Select productID,ProductName,UnitPrice from Products",cn);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            return ds;

        }

        public System.Data.DataSet listarporCodigo(int codigo)
        {
            SqlDataAdapter dap = new SqlDataAdapter("Select productID,ProductName,UnitPrice from Products where ProductID=@codigo", cn);
            dap.SelectCommand.Parameters.AddWithValue("Codigo",codigo);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            return ds;

        }

        public System.Data.DataSet listarporNombre(string Nombre)
        {
            SqlDataAdapter dap = new SqlDataAdapter("Select productID,ProductName,UnitPrice from Products WHERE ProductName LIKE @Nombre+'%'", cn);
            dap.SelectCommand.Parameters.AddWithValue("Nombre",Nombre);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            return ds;
        }
    }
}
