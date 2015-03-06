using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Proyectov1conBd
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }
        SqlConnection Cn = new SqlConnection(Proyectov1conBd.Properties.Settings.Default.NWCN);
        private void Form1_Load(object sender, EventArgs e)
        {
            loadGrid();
            btnNuevo.Click+=new EventHandler(accion_Click);
            btnEditar.Click+=new EventHandler(accion_Click);
            btnBorrar.Click+=new EventHandler(accion_Click);
                       
        }

         private void loadGrid()
            {
            SqlCommand cmd = new SqlCommand("usp_mDatos",Cn);
            cmd.CommandType= CommandType.StoredProcedure;
            Cn.Open();
            SqlDataReader lector = cmd.ExecuteReader(CommandBehavior.SingleResult);
            BindingSource bs = new BindingSource();
            bs.DataSource=lector;
            dgvLista.DataSource=bs;
            Cn.Close();
            }
        void  accion_Click(object sender, EventArgs e)
        {
 	        frmDatos frm = new frmDatos();
            DataGridViewRow fila= dgvLista.CurrentRow;
            switch ((((Button)sender).Tag.ToString()))
	    {
		
                case "Nuevo":
                  frm.mInicio= frmDatos.MenuInicio.Nuevo;
                 break;
                case "Editar":
                  frm.mInicio= frmDatos.MenuInicio.Editar;
                  frm.Codigo=Convert.ToInt32(fila.Cells["idempleado"].Value);
                  frm.NombreCompleto=fila.Cells["nombrecompleto"].Value.ToString();
                  frm.Area_= fila.Cells["area"].Value.ToString();
                 break;
                case "Borrar":
                    frm.Codigo=Convert.ToInt32(fila.Cells["idempleado"].Value);
                    frm.NombreCompleto= fila.Cells["nombrecompleto"].Value.ToString();
                    frm.Area_=fila.Cells["area"].Value.ToString();
                    frm.mInicio=frmDatos.MenuInicio.Borrar;
                    break;
                default:
                break;
	        }
                DialogResult rpta = frm.ShowDialog();
                 if (rpta == DialogResult.OK)
	        {
		         loadGrid();
	        }

        }
    }
}
