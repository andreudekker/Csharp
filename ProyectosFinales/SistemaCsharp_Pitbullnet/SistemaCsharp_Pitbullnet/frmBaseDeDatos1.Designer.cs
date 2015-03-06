namespace SistemaCsharp_Pitbullnet
{
    partial class frmBaseDeDatos1
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAbrirFoto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboArticulos = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.txtCantidadArticulos = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(227, 346);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            //this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            //// btnAbrirFoto
            // 
            this.btnAbrirFoto.Location = new System.Drawing.Point(45, 334);
            this.btnAbrirFoto.Name = "btnAbrirFoto";
            this.btnAbrirFoto.Size = new System.Drawing.Size(75, 23);
            this.btnAbrirFoto.TabIndex = 1;
            this.btnAbrirFoto.Text = ".....";
            this.btnAbrirFoto.UseVisualStyleBackColor = true;
            //this.btnAbrirFoto.Click += new System.EventHandler(this.btnAbrirFoto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // cboArticulos
            // 
            this.cboArticulos.FormattingEnabled = true;
            this.cboArticulos.Location = new System.Drawing.Point(227, 163);
            this.cboArticulos.Name = "cboArticulos";
            this.cboArticulos.Size = new System.Drawing.Size(121, 21);
            this.cboArticulos.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(227, 72);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NombreCompleto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad de articulos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Articulos";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.AcceptsReturn = true;
            this.txtNombreCompleto.Location = new System.Drawing.Point(230, 122);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCompleto.TabIndex = 6;
            // 
            // txtCantidadArticulos
            // 
            this.txtCantidadArticulos.Location = new System.Drawing.Point(227, 210);
            this.txtCantidadArticulos.Name = "txtCantidadArticulos";
            this.txtCantidadArticulos.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadArticulos.TabIndex = 7;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(227, 287);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(398, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 249);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frmBaseDeDatos1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 390);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCantidadArticulos);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.cboArticulos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAbrirFoto);
            this.Controls.Add(this.btnGuardar);
            this.Name = "frmBaseDeDatos1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBaseDeDatos1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAbrirFoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboArticulos;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.TextBox txtCantidadArticulos;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}