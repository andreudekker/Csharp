using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConexionBD_con_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Idata objData;
        DataSet ds = new DataSet();
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (radioEmpleado.Checked)
            {
                objData = new Empleado();
            }
            else
                objData = new Productos();
           
            if (txtCodigo.Text=="" && txtNombre.Text=="")
            {
                ds = objData.Listar();
            }
            else
            {
                if (txtCodigo.Text !="")
                {
                    ds=objData.listarporCodigo(Convert.ToInt32(txtCodigo.Text));

                }

                else if(txtNombre.Text !="")
	            {
                ds=objData.listarporNombre(txtNombre.Text);
	            }
            }
        
           dgvData.DataSource=ds.Tables[0];     
        }

      
    }
}
