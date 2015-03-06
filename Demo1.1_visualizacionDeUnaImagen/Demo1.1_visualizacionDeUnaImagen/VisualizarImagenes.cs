using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Demo1._1_visualizacionDeUnaImagen
{
    public partial class VisualizarImagenes : Form
    {
        public VisualizarImagenes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            {
                fbd.SelectedPath = cboUnidad.Text;
                txtDirectorio.Text = fbd.SelectedPath;
                if (fbd.ShowDialog()==System.Windows.Forms.DialogResult.OK)
                {
                    txtDirectorio.Text = fbd.SelectedPath;
                    mostrarImagenes();
                }
            }
        }

        private void mostrarImagenes()
        {
            DirectoryInfo df = new DirectoryInfo(txtDirectorio.Text);
             FileInfo[] archivos= df.GetFiles("*.jpg", SearchOption.AllDirectories);
             foreach (FileInfo item in archivos)
             {
                 lstArchivos.Items.Add(item.FullName);
             }
        }

        private void VisualizarImagenes_Load(object sender, EventArgs e)
        {
            DriveInfo[] unidades = DriveInfo.GetDrives();
            foreach (DriveInfo item in unidades)
            {
                cboUnidad.Items.Add(item.Name);
            }
            cboUnidad.SelectedIndex = 0;
        }

        private void lstArchivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            PicFoto.Image = Image.FromFile(lstArchivos.Text);
        }
    }
}
