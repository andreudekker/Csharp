using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaCsharp_Pitbullnet
{
    public partial class frmWebService : Form
    {
        public frmWebService()
        {
            InitializeComponent();
        }



        DataSet ds;
        WsPrueba.EmpleadoSoapClient objWsPrueba = new WsPrueba.EmpleadoSoapClient();
       
        
        private void btnWebService_Click(object sender, EventArgs e)
        {
            ds = objWsPrueba.listarEmpleados();
            dgvWs.DataSource= ds.Tables[0];

            txtMensaje1.Text = objWsPrueba.HelloWorld();
        }

       


        
    }
}
