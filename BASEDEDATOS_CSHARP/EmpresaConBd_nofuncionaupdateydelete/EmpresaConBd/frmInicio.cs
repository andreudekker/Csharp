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

namespace EmpresaConBd
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }
        SqlConnection Cn = new SqlConnection(EmpresaConBd.Properties.Settings.Default.NWCN);
        private void Form1_Load(object sender, EventArgs e)
        {
           
            loadGrid();
            btnNuevo.Click += new EventHandler(Accion_Click);
            btnEditar.Click+= new EventHandler(Accion_Click);
            btnBorrar.Click += new EventHandler(Accion_Click);
        }
            private void loadGrid()
            {
                    SqlCommand cmd = new SqlCommand("usp_mDatos", Cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    Cn.Open();
                    SqlDataReader lector = cmd.ExecuteReader(CommandBehavior.SingleResult);
                    BindingSource bs = new BindingSource();
                    bs.DataSource = lector;
                    dgvLista.DataSource = bs;
                    Cn.Close();
            }
            

        void Accion_Click(object sender, EventArgs e)
        {
            frmDatos frm = new frmDatos();
            DataGridViewRow fila = dgvLista.CurrentRow;
            switch ((((Button)sender).Tag.ToString()))
            {
                case "Nuevo":
                    frm.mInicio_ = frmDatos.mInicio.Nuevo;
                   break;
                case "Editar":
                   frm.mInicio_ = frmDatos.mInicio.Editar;
                   frm.id_empleado_ = Convert.ToInt32(fila.Cells["id_empleado"].Value);
                   frm.nombrecompleto = fila.Cells["nombrecompleto"].Value.ToString();
                   frm.area = fila.Cells["area"].Value.ToString();
                  break;
                case "Borrar":
                  frm.id_empleado_ = Convert.ToInt32(fila.Cells["id_empleado"].Value);
                  frm.nombrecompleto = fila.Cells["nombrecompleto"].Value.ToString();
                  frm.area = fila.Cells["area"].Value.ToString();
                  frm.mInicio_ = frmDatos.mInicio.Borrar;
                    break;
            }
            DialogResult rpta = frm.ShowDialog();
            if (rpta== DialogResult.OK)
            {
                loadGrid();
            }
        
        }
    }
}
