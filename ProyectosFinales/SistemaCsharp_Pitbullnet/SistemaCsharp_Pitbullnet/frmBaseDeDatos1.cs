using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaCsharp_Pitbullnet
{
    public partial class frmBaseDeDatos1 : Form
    {
        public frmBaseDeDatos1()
        {
            InitializeComponent();
        }

        private void btnAbrirFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = new DialogResult();
            if (result==DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dialog.FileName);    
            }
        }
    }
}
