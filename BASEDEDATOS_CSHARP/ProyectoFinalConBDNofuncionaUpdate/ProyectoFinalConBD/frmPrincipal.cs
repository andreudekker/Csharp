using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ProyectoFinalConBD
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
           

        }
        SqlConnection Cn = new SqlConnection(ProyectoFinalConBD.Properties.Settings.Default.NWCN);
        private void frmPrincipal_Load(object sender, EventArgs e)
        {


            loadGrid();
            btnNuevo.Click += new EventHandler(Operacion_Click);
            btnModificar.Click += new EventHandler(Operacion_Click);
            btnBorrar.Click += new EventHandler(Operacion_Click);
         
           
        }

        private void loadGrid()
        {
            SqlCommand cmd = new SqlCommand("usp_mDatos", Cn);
            cmd.CommandType = CommandType.StoredProcedure;
            Cn.Open();
            SqlDataReader lector = cmd.ExecuteReader(CommandBehavior.SingleResult);
            BindingSource bs = new BindingSource();
            bs.DataSource = lector;
            dgvProductos.DataSource = bs;
            Cn.Close();
        }

        void Operacion_Click(object sender, EventArgs e)
        {
            frmDatos frm = new frmDatos();
            DataGridViewRow fila = dgvProductos.CurrentRow;
            switch ((((Button)sender).Tag.ToString()))
            { 
                case "Nuevo":
                    frm.operacion = frmDatos.Operacion.Nuevo;
                    break;
                case "Editar":
                    frm.operacion=frmDatos.Operacion.Editar;
                    frm.Id_Empleado=Convert.ToInt32(fila.Cells["Id_Empleado"].Value);
                    frm.NombreCompleto=fila.Cells["NombreCompleto"].Value.ToString();
                    frm.Departamento = fila.Cells["NombreDepartamento"].Value.ToString();
                     break;
                case "Eliminar":
                    frm.Id_Empleado=Convert.ToInt32(fila.Cells["Id_Empleado"].Value);
                    frm.NombreCompleto=fila.Cells["NombreCompleto"].Value.ToString();
                    frm.Departamento = fila.Cells["NombreDepartamento"].Value.ToString();
                    frm.operacion=frmDatos.Operacion.Eliminar;
                break;
            }
           
            DialogResult rpta =frm.ShowDialog();
                    if (rpta==DialogResult.OK)
	{
                    loadGrid();
                        
	}
                    //else if (rpta == DialogResult.Cancel)
                    //{

                    //}
            
        }
    }
}
