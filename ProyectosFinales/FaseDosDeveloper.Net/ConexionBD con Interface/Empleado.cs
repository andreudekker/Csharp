using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ConexionBD_con_Interface
{
   public class Empleado: Idata
    {
       SqlConnection cn = new SqlConnection("Server=.; DataBase=Northwind;Integrated Security=true");

        public DataSet Listar()
        {
            SqlDataAdapter dap = new SqlDataAdapter("SELECT employeeID,FirstName,LastName,Title FROM Employees",cn);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            return ds;
        }

        public DataSet listarporCodigo(int codigo)
        {
            SqlDataAdapter dap = new SqlDataAdapter("SELECT employeeID,FirstName,LastName,Title FROM Employees WHERE employeeID=@Codigo ", cn);
            dap.SelectCommand.Parameters.AddWithValue("Codigo", codigo);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            return ds;
        }

        public DataSet listarporNombre(string Nombre)
        {
            SqlDataAdapter dap = new SqlDataAdapter("SELECT employeeID,FirstName,LastName,Title FROM Employees WHERE firstName LIKE @Nombre+'%", cn);
            dap.SelectCommand.Parameters.AddWithValue("Nombre", @Nombre);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            return ds;
        }
    }
}
