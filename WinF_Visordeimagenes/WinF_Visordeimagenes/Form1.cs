using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Solucion_Demo03_VisualizadordeImagenes_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    

        private void Form1_Load(object sender, EventArgs e)
        {
            DriveInfo[] unidades = DriveInfo.GetDrives();
            foreach (DriveInfo item in unidades)
            {
                cboUnidad.Items.Add(item.Name);
            }
            cboUnidad.SelectedIndex = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            {
                fbd.SelectedPath = cboUnidad.Text;
               
                if (fbd.ShowDialog()==System.Windows.Forms.DialogResult.OK)
                {
                    txtDirectorio.Text = fbd.SelectedPath;
                    mostrarArchivos();
    
                }

            }
        }

        private void mostrarArchivos()
        {
            DirectoryInfo df = new DirectoryInfo(txtDirectorio.Text);
            FileInfo[] archivos=  df.GetFiles("*.*jpg", SearchOption.AllDirectories);

            foreach (FileInfo item in archivos)
            {
                lstArchivos.Items.Add(item.FullName);
            }
        
        }

        private void lstArchivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            picFoto.Image = Image.FromFile(lstArchivos.Text);
        }
    }
}
