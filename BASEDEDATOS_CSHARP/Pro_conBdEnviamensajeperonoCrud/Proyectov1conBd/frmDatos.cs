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

    namespace Proyectov1conBd
    {
        public partial class frmDatos : Form
        {
            public frmDatos()
            {
                InitializeComponent();
            }

             public enum MenuInicio : int
            { 
               Nuevo=1,
               Editar=2,
               Borrar=3
            }

             public  MenuInicio mInicio { get; set; }
             public int Codigo { get; set; }
             public string NombreCompleto { get; set; }
             public string Area_ { get; set; }

            SqlConnection Cn = new SqlConnection(Proyectov1conBd.Properties.Settings.Default.NWCN);
            private void frmDatos_Load(object sender, EventArgs e)
            {
                switch (mInicio)
                {
                    case MenuInicio.Nuevo:
                        btnGrabar.Text = "Nuevo Registro";
                        this.Text = "Agregar producto";
                        quitarControles(false);
                        txtCodigo.ReadOnly = true;
                        break;
                    case MenuInicio.Editar:
                        btnGrabar.Text = "Editar";
                        this.Text = "Actualizar";
                        mostrarDatos();
                        quitarControles(false);
                        txtCodigo.ReadOnly=true;
                        break;
                    case MenuInicio.Borrar:
                        btnGrabar.Text = "Borrar";
                        this.Text = "Borrar";
                        mostrarDatos();
                        quitarControles(true);
                        break;
                    default:
                        break;
                }
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
                private void mostrarDatos()
                {
                    txtCodigo.Text=Codigo.ToString();
                    txtNombreCompleto.Text=NombreCompleto.ToString();
                    txtArea.Text=Area_.ToString();
                }

            private void btnGrabar_Click(object sender, EventArgs e)
            {
               SqlCommand cmd= new SqlCommand("",Cn);
                cmd.CommandType= CommandType.StoredProcedure;
                Cn.Open();
                int fila = 0;
                switch (mInicio)
	    {
		                case MenuInicio.Nuevo:
                        cmd.CommandText="usp_aDatos";
                        cmd.Parameters.AddWithValue("idempleado",0);
                        cmd.Parameters.AddWithValue("nombrecompleto",txtNombreCompleto.Text);
                        cmd.Parameters.AddWithValue("area",txtArea.Text);
                        cmd.Parameters["idempleado"].Direction=ParameterDirection.Output;
                        fila= cmd.ExecuteNonQuery();
                         if (fila !=0)
	                    {
		                    MessageBox.Show(@"Se registro con exito"+cmd.Parameters["idempleado"].Value.ToString());
	                    }   
                            break;
                case MenuInicio.Editar:
                        cmd.CommandText="usp_aDatos";
                        cmd.Parameters.AddWithValue("idempleado",0);
                        cmd.Parameters.AddWithValue("nombrecompleto",txtNombreCompleto.Text);
                        cmd.Parameters.AddWithValue("area",txtArea.Text);
                        fila= cmd.ExecuteNonQuery();
                        if (fila !=0)
	                {
	                     MessageBox.Show(@"Se ha actualizado con exito");
	                }
                             break;
                case MenuInicio.Borrar:
                        cmd.CommandText="usp_bDatos";
                        cmd.Parameters.AddWithValue("idempleado",txtCodigo.Text);
                        fila= cmd.ExecuteNonQuery();
                        if (fila!=0)
	                {
		                 MessageBox.Show("Se ha eliminado el  registro");
	                }
                
                        break;
                        default:
                         break;
	    }
            Cn.Close();
            this.DialogResult= DialogResult.OK;
            this.Close();        

            }

            private void btnCerrar_Click(object sender, EventArgs e)
            {
                this.DialogResult=DialogResult.Cancel;
                this.Close();
            }

        
            }
        }
    
