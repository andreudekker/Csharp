using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace DemoRegistroenWindows
{
    public partial class FrmLeerValoresReg : Form
    {
        public FrmLeerValoresReg()
        {
            InitializeComponent();
        }

        string strRuta = @"HKEY_CURRENT_USER\Software\Microsoft\Developer";
        private void FrmLeerValoresReg_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            
            object valor = Registry.GetValue(strRuta,"Titulo",null);
            txtValor.Text =valor.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Registry.SetValue(strRuta, "Titulo", txtValor.Text);
            MessageBox.Show("Se actualizo registro de windows","Developer.Net",MessageBoxButtons.OK , MessageBoxIcon.Information);
        }

        private void FrmLeerValoresReg_FormClosing(object sender, FormClosingEventArgs e)
        {
          DialogResult resul=  MessageBox.Show("Estas seguro de cerrar la ventana", "developer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

          if (resul == System.Windows.Forms.DialogResult.No)
          {
              e.Cancel = true;
          }
        }
    }
}
