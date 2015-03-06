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

namespace _prueba_AplicacionconBD_winform
{
   
    
    public partial class frmIngresoUsuario : Form
    
    {        
        public frmIngresoUsuario()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NWCN"].ConnectionString);
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            #region validaciondedatosTxtBox
            if (txtUsuario.Text=="")
            {
                MessageBox.Show("Debe Ingresar un usuario");
                txtUsuario.Focus();
                return;
            }
            if (txtUsuario.Text=="")
            {
                MessageBox.Show("Debe Ingresar una clave valida");
                txtClave.Focus();
                return;
            }
            this.Hide();
            frmPrincipal f = new frmPrincipal();
            f.Show();
            #endregion
                
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        

        }
    }

