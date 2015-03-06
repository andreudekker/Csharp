using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;






namespace winForm_llamandoalWebServiceSimple
{
    public partial class ListarEmpleados : Form
    {
        public ListarEmpleados()
        {
            InitializeComponent();
        }

        DataSet ds;
     
       WSEmpleado.EmpleadoSoapClient oWSEmpleado = new WSEmpleado.EmpleadoSoapClient();
        private void btnListar_Click(object sender, EventArgs e)
        {
            ds = oWSEmpleado.listarEmpleados();
            dgvListar.DataSource = ds.Tables[0];
        }
    }
}
