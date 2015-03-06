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

namespace ProyectoFinalConBD
{
    public partial class frmDatos : Form
    {
        public frmDatos()
        {
            InitializeComponent();
        }
        public enum Operacion : int 
        {
            Nuevo=1,
            Editar=2,
            Eliminar=3
        }

        public Operacion operacion { get; set; }
        public int Id_Empleado { get; set; }
        public string NombreCompleto { get; set; }
        public string Departamento { get; set; }

        SqlConnection Cn = new SqlConnection(ProyectoFinalConBD.Properties.Settings.Default.NWCN);
        private void frmDatos_Load(object sender, EventArgs e)
        {
            switch (operacion)
            {
                case Operacion.Nuevo:
                    btnGrabar.Text = "Grabar";
                    this.Text = "Agregar Producto";
                    deshabilitarControles(false);
                    txtIdEmpleado.ReadOnly = true;
                    break;
                case Operacion.Editar:
                    btnGrabar.Text = "Actualizar";
                    this.Text = "Editar Producto";
                    mostrarDatos();
                    deshabilitarControles(false);
                    txtIdEmpleado.ReadOnly = true;
                   break;
                case Operacion.Eliminar:
                   btnGrabar.Text = "Eliminar";
                   this.Text = "Eliminar Productos";
                   mostrarDatos();
                   deshabilitarControles(true);
                    break;
                default:
                    break;
            }
        }

        private void deshabilitarControles(bool estado)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).ReadOnly=estado;
                }
            }
        }

        private void mostrarDatos()
        {
            txtIdEmpleado.Text = Id_Empleado.ToString();
            txtNombreCompleto.Text = NombreCompleto.ToString();
            txtDepartamento.Text = Departamento.ToString();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new  SqlCommand("",Cn);
            cmd.CommandType = CommandType.StoredProcedure;
            Cn.Open();
            int fila = 0;
            switch (operacion)
            {
                case Operacion.Nuevo:
                    cmd.CommandText = "usp_iDatos";
                    cmd.Parameters.AddWithValue("Id_Empleado", 0);
                    cmd.Parameters.AddWithValue("NombreCompleto", txtNombreCompleto.Text);
                    cmd.Parameters.AddWithValue("NombreDepartamento ", txtDepartamento.Text);
                    cmd.Parameters["Id_Empleado"].Direction = ParameterDirection.Output;
                    fila = cmd.ExecuteNonQuery();
                    if (fila !=0)
                    {
                        MessageBox.Show(@"Se registro con exito" + cmd.Parameters["Id_Empleado"].Value.ToString());
                    }
                    break;
                case Operacion.Editar:
                    cmd.CommandText = "usp_aDatos";
                    cmd.Parameters.AddWithValue("Id_Empleado", 0);
                    cmd.Parameters.AddWithValue("NombreCompleto", txtNombreCompleto.Text);
                    cmd.Parameters.AddWithValue("NombreDepartamento", txtDepartamento.Text);
                    fila = cmd.ExecuteNonQuery();
                    if (fila !=0)
                    {
                        MessageBox.Show("Se ha actualizado registro");
                    }
                    break;
                case Operacion.Eliminar:
                    cmd.CommandText = "usp_bDatos";
                    cmd.Parameters.AddWithValue("Id_Empleado",txtIdEmpleado.Text);
                    fila = cmd.ExecuteNonQuery();
                    if (fila !=0)
                    {
                        MessageBox.Show("Se ha eliminado el registro");
                    }
                    break;
                default:
                    break;
            }
            Cn.Close();
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
