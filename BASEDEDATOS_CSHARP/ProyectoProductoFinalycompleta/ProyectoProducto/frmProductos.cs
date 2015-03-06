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

namespace ProyectoProducto
{
    public partial class frmProductos : Form
    {

          #region EnlaceYcargaDeDatosBD
        SqlConnection cn = new SqlConnection(ProyectoProducto.Properties.Settings.Default.NWCN);
        SqlDataAdapter dap = new SqlDataAdapter();
        BindingSource bs = new BindingSource();
        DataSet ds = new DataSet();
        #endregion

        public frmProductos()
        {
            InitializeComponent();
        }
        
       
        private void Form1_Load(object sender, EventArgs e)
        {
            #region MostrarDatos
            dap.SelectCommand = new SqlCommand("mostrarDatosEmpleado", cn);
            ds.Clear();
            dap.Fill(ds);
            dgvDatos.DataSource = ds.Tables[0];
            bs.DataSource = ds.Tables[0];
            txtIdEmpleado.DataBindings.Add(new Binding("text", bs, "ID_Empleado"));
            txtNombreCompleto.DataBindings.Add(new Binding("text", bs, "NombreCompleto"));
            txtEstadoCivil.DataBindings.Add(new Binding("text", bs, "EstadoCivl"));
            //dgvUpdate();
            #endregion
        }


        #region BotonesDeDesplazamiento
        private void btnPrimero_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
            dgvUpdate();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
            dgvUpdate();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
            dgvUpdate();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
            dgvUpdate();
        }
        #endregion


        #region InsertarDatos
        int fila = 0;
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
            
            SqlCommand cmd = new SqlCommand("insertarDatosEmpleado", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            cmd.Parameters.AddWithValue("Id_Empleado", 0);
            cmd.Parameters.AddWithValue("NombreCompleto", txtNombreCompleto.Text);
            cmd.Parameters.AddWithValue("EstadoCivl", txtEstadoCivil.Text);
            cmd.Parameters["Id_Empleado"].Direction = ParameterDirection.Output;
            fila = cmd.ExecuteNonQuery();
            if (fila != 0)
            {
                MessageBox.Show(@"Se registro con exito" + cmd.Parameters["Id_Empleado"].Value.ToString());
                
            }
            CargarGrid();
        
        }
        #endregion

        #region EditarDatos
        private void btnEditar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("actualizarDatosEmpleado", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();

            cmd.Parameters.AddWithValue("Id_Empleado", txtIdEmpleado.Text);
            cmd.Parameters.AddWithValue("NombreCompleto",txtNombreCompleto.Text);
            cmd.Parameters.AddWithValue("EstadoCivl",txtEstadoCivil.Text);
            fila = cmd.ExecuteNonQuery();
            if (fila != 0)
            {
                MessageBox.Show("Se ha actualizado registro");
            }
            CargarGrid();
            cn.Close();
        
        }
        #endregion


        #region BorrarDatos
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("BorrarDatosEmpleado", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();          
            cmd.Parameters.AddWithValue("Id_Empleado", txtIdEmpleado.Text);
            int fila = cmd.ExecuteNonQuery();
            if (fila != 0)
            {
                MessageBox.Show("Se ha eliminado el registro");
            }

            CargarGrid();
            cn.Close();
        }
        #endregion


        #region LimpiarControles
        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            limpiarControles();
        }



        public void limpiarControles()
        {
            foreach (Control ctrl in this.Controls)      
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = String.Empty;
                }
            }
        }
        #endregion


        #region actualizarGrilla
        private void dgvUpdate()
        {
            dgvDatos.ClearSelection(); //desmarca lo del usuario
            dgvDatos.Rows[bs.Position].Selected = true;

        }
        #endregion


        #region cargarGrillaEnCrud
        private void CargarGrid()
        {
              DataTable dt = new DataTable();
              SqlCommand cmd = new SqlCommand("mostrarDatosEmpleado", cn);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(dt);

                dgvDatos.DataSource = dt;            
        }
        #endregion


        #region CargarGrillaEnTexbox
        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)dgvDatos.Rows[e.RowIndex];
            if (row.Index != 0)
            {
                txtIdEmpleado.Text = Convert.ToString(row.Cells[0].Value);
                txtNombreCompleto.Text = Convert.ToString(row.Cells[1].Value);
                txtEstadoCivil.Text = Convert.ToString(row.Cells[2].Value);
            }
        }

        #endregion


    }

   
}
