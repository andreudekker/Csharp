using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Demo05_ConexoinBD_ado
{

    public enum Tabla_SQL
    { 
      
        Categories=1,
        CustomerCustomerDemo=2,
        CustomerDemographics=3,
        Customers=4,
        Employees=5,
        EmployeeTerritories=6,
        Order_Details=7,
        Orders=8,
        Products=9,
        Region=10,
        Shippers=11,
        Suppliers=12,
        Territories=13,
    }

    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conexion = new SqlConnection(@"Server=.;DataBase=Northwind;Integrated Security=TRUE");
            //conexion.Open();
            //conexion.Close();
            conexion.Open();
            DataTable tbltablas = conexion.GetSchema("Tables");
            DataView dv = tbltablas.DefaultView;
            dv.RowFilter = "TABLE_TYPE='BASE TABLE' ";
            tbltablas = dv.ToTable();
            Console.WriteLine("Seleccione su tabla a visualizar:");
            int posicion = 0;
            foreach (DataRow item in tbltablas.Rows)
            {
                posicion++;
                Console.WriteLine(posicion.ToString() + ":" + item["TABLE_NAME"].ToString());
            }
            Console.WriteLine();
            Console.Write("Ingrese el codigo de la tabla para visualizar: ");
            int intTabla =Convert.ToInt32( Console.ReadLine());
            Tabla_SQL  tb = (Tabla_SQL)intTabla;
            string Tabla = Enum.GetName(typeof(Tabla_SQL), tb);
            string SQL = "select * from" + Tabla;
            SqlDataAdapter dap = new SqlDataAdapter(SQL, conexion);
            dap.SelectCommand.CommandType = CommandType.Text;
            DataTable tblInfo = new DataTable();
            dap.Fill(tblInfo);
            for (int i = 0; i < tblInfo.Rows.Count; i++)
            {

                string strInfo = " ";
                for (int j = 0; j < tblInfo.Columns.Count; j++)
                {
                    strInfo += tblInfo.Rows[i][j].ToString() + "\t";
                }
                Console.WriteLine(strInfo);
                Console.ReadLine();
            }



            Console.ReadLine();


        }
    }
}
