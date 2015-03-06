namespace SistemaCsharp_Pitbullnet
{
    partial class frmPrincipalcs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipalcs));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conceptosBasicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conceptosDePooToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linqToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRUDSQLserver2008ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeMiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.conceptosBasicosToolStripMenuItem,
            this.datosToolStripMenuItem,
            this.acercaDeMiToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(817, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Image = global::SistemaCsharp_Pitbullnet.Properties.Resources.Archivo_48x48;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::SistemaCsharp_Pitbullnet.Properties.Resources.Puerta;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // conceptosBasicosToolStripMenuItem
            // 
            this.conceptosBasicosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conceptosDePooToolStripMenuItem});
            this.conceptosBasicosToolStripMenuItem.Image = global::SistemaCsharp_Pitbullnet.Properties.Resources.Concepto_48x48;
            this.conceptosBasicosToolStripMenuItem.Name = "conceptosBasicosToolStripMenuItem";
            this.conceptosBasicosToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.conceptosBasicosToolStripMenuItem.Text = "Conceptos Basicos";
            // 
            // conceptosDePooToolStripMenuItem
            // 
            this.conceptosDePooToolStripMenuItem.Image = global::SistemaCsharp_Pitbullnet.Properties.Resources.cb_48x48;
            this.conceptosDePooToolStripMenuItem.Name = "conceptosDePooToolStripMenuItem";
            this.conceptosDePooToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.conceptosDePooToolStripMenuItem.Text = "Conceptos de Poo";
            this.conceptosDePooToolStripMenuItem.Click += new System.EventHandler(this.conceptosDePooToolStripMenuItem_Click);
            // 
            // datosToolStripMenuItem
            // 
            this.datosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linqToolStripMenuItem,
            this.webServiceToolStripMenuItem,
            this.cRUDSQLserver2008ToolStripMenuItem});
            this.datosToolStripMenuItem.Image = global::SistemaCsharp_Pitbullnet.Properties.Resources.BD_48x48_1_;
            this.datosToolStripMenuItem.Name = "datosToolStripMenuItem";
            this.datosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.datosToolStripMenuItem.Text = "Datos";
            // 
            // linqToolStripMenuItem
            // 
            this.linqToolStripMenuItem.Image = global::SistemaCsharp_Pitbullnet.Properties.Resources.CB;
            this.linqToolStripMenuItem.Name = "linqToolStripMenuItem";
            this.linqToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.linqToolStripMenuItem.Text = "Linq";
            this.linqToolStripMenuItem.Click += new System.EventHandler(this.linqToolStripMenuItem_Click);
            // 
            // webServiceToolStripMenuItem
            // 
            this.webServiceToolStripMenuItem.Image = global::SistemaCsharp_Pitbullnet.Properties.Resources.webService_64x64;
            this.webServiceToolStripMenuItem.Name = "webServiceToolStripMenuItem";
            this.webServiceToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.webServiceToolStripMenuItem.Text = "Web Service";
            this.webServiceToolStripMenuItem.Click += new System.EventHandler(this.webServiceToolStripMenuItem_Click);
            // 
            // cRUDSQLserver2008ToolStripMenuItem
            // 
            this.cRUDSQLserver2008ToolStripMenuItem.Image = global::SistemaCsharp_Pitbullnet.Properties.Resources.Crud_64x64;
            this.cRUDSQLserver2008ToolStripMenuItem.Name = "cRUDSQLserver2008ToolStripMenuItem";
            this.cRUDSQLserver2008ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.cRUDSQLserver2008ToolStripMenuItem.Text = "CRUD SQLserver2008";
            this.cRUDSQLserver2008ToolStripMenuItem.Click += new System.EventHandler(this.cRUDSQLserver2008ToolStripMenuItem_Click);
            // 
            // acercaDeMiToolStripMenuItem
            // 
            this.acercaDeMiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.acercaDeMiToolStripMenuItem.Image = global::SistemaCsharp_Pitbullnet.Properties.Resources.acerca_48x48;
            this.acercaDeMiToolStripMenuItem.Name = "acercaDeMiToolStripMenuItem";
            this.acercaDeMiToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.acercaDeMiToolStripMenuItem.Text = "Acerca de Mi";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Image = global::SistemaCsharp_Pitbullnet.Properties.Resources.Acercademi;
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // frmPrincipalcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 560);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmPrincipalcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema VisualNet";
            this.Load += new System.EventHandler(this.frmPrincipalcs_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conceptosBasicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conceptosDePooToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linqToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRUDSQLserver2008ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeMiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
    }
}



