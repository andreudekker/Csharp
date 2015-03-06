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

namespace EmpresaConBd
{
    public partial class frmDatos : Form
    {
        public frmDatos()
        {
            InitializeComponent();
        }

        public enum mInicio: int
        {
           Nuevo =1,
            Editar=2,
            Borrar=3
        }

        public mInicio mInicio_ { get; set; }
        public int id_empleado_ { get; set; }
        public string nombrecompleto { get; set; }
        public string area { get; set; }
       
        SqlConnection Cn = new SqlConnection(EmpresaConBd.Properties.Settings.Default.NWCN); 

        private void frmDatos_Load(object sender, EventArgs e)
        {
            switch (mInicio_)
            {
                case mInicio.Nuevo:
                    btnGrabar.Text = "Grabar";
                    this.Text = "Nuevo";
                    quitarControles(false);
                    txtId.ReadOnly = true;
                    break;
                case mInicio.Editar:
                    btnGrabar.Text = "Actualizar";
                    this.Text = "Editar";
                    mostrarDatos();
                    quitarControles(false);
                    txtId.ReadOnly = true;
                    break;
                case mInicio.Borrar:
                    btnGrabar.Text = "Eliminar";
                    this.Text = "Borrar";
                    mostrarDatos();
                    quitarControles(true);

                    break;
                default:
                    break;
            }
        }

        private void mostrarDatos()
        {
            txtId.Text = id_empleado_.ToString();
            txtNombreC.Text = nombrecompleto.ToString();
            txtArea.Text = area.ToString();
        }

        private void quitarControles(bool estado)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).ReadOnly = estado;
                }
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(" ", Cn);
            cmd.CommandType = CommandType.StoredProcedure;
            Cn.Open();
            int fila =0;
            switch (mInicio_)
	{
		            case mInicio.Nuevo:
                                   cmd.CommandText="usp_iDatos";
                                   cmd.Parameters.AddWithValue("id_empleado",0);
                                   cmd.Parameters.AddWithValue("nombrecompleto",txtNombreC.Text);
                                   cmd.Parameters.AddWithValue("area",txtArea.Text);
                                  cmd.Parameters["id_empleado"].Direction =ParameterDirection.Output;
                                   fila = cmd.ExecuteNonQuery();
                                  if (fila !=0)
	                                {
                                      MessageBox.Show("Registro ok"+cmd.Parameters["id_empleado"].Value.ToString());
	                                }
                        
                        break;
                        case mInicio.Editar:
                                cmd.CommandText="usp_aDatos";
                                cmd.Parameters.AddWithValue("id_empleado",0);
                                cmd.Parameters.AddWithValue("nombrecompleto",txtNombreC.Text);
                                cmd.Parameters.AddWithValue("area",txtArea.Text);
                                fila =cmd.ExecuteNonQuery();
                                if (fila!=0)
	                                {
		                                    MessageBox.Show("Se Actualizo Ok");
	                                }
                            break;
                        case mInicio.Borrar:
                                cmd.CommandText="usp_bDatos";
                                cmd.Parameters.AddWithValue("id_empleado",0);
                                fila= cmd.ExecuteNonQuery();
                                if (fila!=0)
	                            {
		                            MessageBox.Show("Registro Borrado");
	                            }
                        break;                    
	                }
                        Cn.Close();
                        this.DialogResult=DialogResult.OK;
                        this.Close();
            }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
