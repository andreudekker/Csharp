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
    public partial class frmEnum : Form
    {
        public frmEnum()
        {
            InitializeComponent();
        }

        private void btnAceptas_Click(object sender, EventArgs e)
        {
            switchColores color = (switchColores)Convert.ToInt32(textBox1.Text);  //conversion de enum a int para capturar variables
            listBox1.Items.Add(color);
            switch (color)
            {
                case switchColores.Verde:
                    listBox1.BackColor = System.Drawing.Color.Green;
                    listBox1.Items.Clear();
                    break;
                case switchColores.Amarrillo:
                    listBox1.BackColor = System.Drawing.Color.Yellow;
                    listBox1.Items.Clear();
                    break;
                case switchColores.Rojo:
                    listBox1.BackColor = System.Drawing.Color.Red;
                    listBox1.Items.Clear();
                    break;
                default:
                    MessageBox.Show("El valor no  es correcto");
                    listBox1.Items.Clear();
                    break;
            }
        }
        public enum switchColores
        {
            Verde = 1,
            Amarrillo,
            Rojo
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEnum_Load(object sender, EventArgs e)
        {

        }
    }
}
