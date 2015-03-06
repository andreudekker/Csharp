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

namespace ExamenFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(ExamenFinal.Properties.Settings.Default.NWCN);
        SqlDataAdapter dap = new SqlDataAdapter();
        BindingSource bs = new BindingSource();
        DataSet ds = new DataSet();
        
        private void Form1_Load(object sender, EventArgs e)
        {          
            dap.SelectCommand = new SqlCommand("usp_mDatos", cn);
            ds.Clear();
            dap.Fill(ds);
            dgvDatos.DataSource = ds.Tables[0];
            bs.DataSource = ds.Tables[0];
            txtCodigo.DataBindings.Add(new Binding("text", bs, "id_empleado"));
            txtNombre.DataBindings.Add(new Binding("text", bs, "nombrecompleto"));
            txtArea.DataBindings.Add(new Binding("text", bs, "area"));
        }


        int fila = 0;
        private void btnNuevo_Click(object sender, EventArgs e)
        {
             SqlCommand cmd = new  SqlCommand("",cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            int fila = 0;
                             
                    cmd.CommandText = "usp_iDatos";
                    cmd.Parameters.AddWithValue("Id_Empleado", 0);
                    cmd.Parameters.AddWithValue("NombreCompleto", txtNombre.Text);
                    cmd.Parameters.AddWithValue("Area", txtArea.Text);
                    cmd.Parameters["Id_Empleado"].Direction = ParameterDirection.Output;
                    fila = cmd.ExecuteNonQuery();
                    if (fila !=0)
                    {
                        MessageBox.Show(@"Se registro con exito" + cmd.Parameters["Id_Empleado"].Value.ToString());
                    }
                
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            int fila = 0;
            cmd.CommandText = "usp_aDatos";
            cmd.Parameters.AddWithValue("Id_Empleado", 0);
            cmd.Parameters.AddWithValue("NombreCompleto", txtNombre.Text);
            cmd.Parameters.AddWithValue("Area", txtArea.Text);
            fila = cmd.ExecuteNonQuery();
            if (fila != 0)
            {
                MessageBox.Show("Se ha actualizado registro");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            cmd.CommandText = "usp_bDatos";
            cmd.Parameters.AddWithValue("Id_Empleado", txtCodigo.Text);
            int fila = cmd.ExecuteNonQuery();
            if (fila != 0)
            {
                MessageBox.Show("Se ha eliminado el registro");
            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void dgvUpdate()
        {
            dgvDatos.ClearSelection(); //desmarca lo del usuario
            dgvDatos.Rows[bs.Position].Selected = true;

        }

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
        private void limpiar()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtArea.Text = " ";
       
        }
    
    
    
    }
}
