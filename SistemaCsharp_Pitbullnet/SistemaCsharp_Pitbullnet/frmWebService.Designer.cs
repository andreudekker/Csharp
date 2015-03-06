namespace SistemaCsharp_Pitbullnet
{
    partial class frmWebService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWebService));
            this.txtMensaje1 = new System.Windows.Forms.TextBox();
            this.btnWebService = new System.Windows.Forms.Button();
            this.dgvWs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWs)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMensaje1
            // 
            this.txtMensaje1.Location = new System.Drawing.Point(159, 195);
            this.txtMensaje1.Name = "txtMensaje1";
            this.txtMensaje1.Size = new System.Drawing.Size(200, 20);
            this.txtMensaje1.TabIndex = 0;
            // 
            // btnWebService
            // 
            this.btnWebService.Location = new System.Drawing.Point(159, 247);
            this.btnWebService.Name = "btnWebService";
            this.btnWebService.Size = new System.Drawing.Size(189, 23);
            this.btnWebService.TabIndex = 1;
            this.btnWebService.Text = "Ejecutar Web Service";
            this.btnWebService.UseVisualStyleBackColor = true;
            this.btnWebService.Click += new System.EventHandler(this.btnWebService_Click);
            // 
            // dgvWs
            // 
            this.dgvWs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWs.Location = new System.Drawing.Point(3, 8);
            this.dgvWs.Name = "dgvWs";
            this.dgvWs.Size = new System.Drawing.Size(382, 168);
            this.dgvWs.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mensaje desde WebService";
            // 
            // frmWebService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 338);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvWs);
            this.Controls.Add(this.btnWebService);
            this.Controls.Add(this.txtMensaje1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmWebService";
            this.Text = "Web Service";
       
            ((System.ComponentModel.ISupportInitialize)(this.dgvWs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMensaje1;
        private System.Windows.Forms.Button btnWebService;
        private System.Windows.Forms.DataGridView dgvWs;
        private System.Windows.Forms.Label label1;

    }
}