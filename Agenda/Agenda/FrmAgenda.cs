using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Agenda
{
    public partial class FrmAgenda : Form
    {
        public FrmAgenda()
        {
            InitializeComponent();
        }

        SqlConnection Cn = new SqlConnection(Agenda.Properties.Settings.Default.NWCN);
        private void FrmAgenda_Load(object sender, EventArgs e)
        {

            
          //  SqlCommand cmd = new SqlCommand("",);
           // cmd.CommandType =CommandType.StoredProcedure;

    }

        private void btnAbrirFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result= ofd.ShowDialog();
            if (result==DialogResult.OK)
	            {
                    PicFoto.Image = Image.FromFile(ofd.FileName);
	            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("usp_guardarInformacion", Cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("NombreCompleto", txtNombreCompleto.Text);
            cmd.Parameters.AddWithValue("NombreCompleto", TxtCorreo.Text);
            cmd.Parameters.AddWithValue("Telefono", TxtTelefono.Text);

        }
    }

}

