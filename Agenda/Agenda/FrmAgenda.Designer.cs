namespace Agenda
{
    partial class FrmAgenda
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
            this.BtnNuevoContacto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PicFoto = new System.Windows.Forms.PictureBox();
            this.btnModificarContacto = new System.Windows.Forms.Button();
            this.BtnEliminarContacto = new System.Windows.Forms.Button();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.btnAbrirFoto = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNuevoContacto
            // 
            this.BtnNuevoContacto.Location = new System.Drawing.Point(166, 138);
            this.BtnNuevoContacto.Name = "BtnNuevoContacto";
            this.BtnNuevoContacto.Size = new System.Drawing.Size(131, 23);
            this.BtnNuevoContacto.TabIndex = 0;
            this.BtnNuevoContacto.Text = "Nuevo Contacto";
            this.BtnNuevoContacto.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Correo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Telefono";
            // 
            // PicFoto
            // 
            this.PicFoto.Location = new System.Drawing.Point(3, 12);
            this.PicFoto.Name = "PicFoto";
            this.PicFoto.Size = new System.Drawing.Size(154, 139);
            this.PicFoto.TabIndex = 2;
            this.PicFoto.TabStop = false;
            // 
            // btnModificarContacto
            // 
            this.btnModificarContacto.Location = new System.Drawing.Point(303, 138);
            this.btnModificarContacto.Name = "btnModificarContacto";
            this.btnModificarContacto.Size = new System.Drawing.Size(131, 23);
            this.btnModificarContacto.TabIndex = 0;
            this.btnModificarContacto.Text = "ModificarContacto";
            this.btnModificarContacto.UseVisualStyleBackColor = true;
            // 
            // BtnEliminarContacto
            // 
            this.BtnEliminarContacto.Location = new System.Drawing.Point(452, 138);
            this.BtnEliminarContacto.Name = "BtnEliminarContacto";
            this.BtnEliminarContacto.Size = new System.Drawing.Size(131, 23);
            this.BtnEliminarContacto.TabIndex = 0;
            this.BtnEliminarContacto.Text = "EliminarContacto";
            this.BtnEliminarContacto.UseVisualStyleBackColor = true;
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(353, 30);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(173, 20);
            this.txtNombreCompleto.TabIndex = 3;
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(353, 62);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(173, 20);
            this.TxtCorreo.TabIndex = 3;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(353, 96);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(173, 20);
            this.TxtTelefono.TabIndex = 3;
            // 
            // btnAbrirFoto
            // 
            this.btnAbrirFoto.Location = new System.Drawing.Point(3, 157);
            this.btnAbrirFoto.Name = "btnAbrirFoto";
            this.btnAbrirFoto.Size = new System.Drawing.Size(75, 23);
            this.btnAbrirFoto.TabIndex = 4;
            this.btnAbrirFoto.Text = "AbrirFoto";
            this.btnAbrirFoto.UseVisualStyleBackColor = true;
            this.btnAbrirFoto.Click += new System.EventHandler(this.btnAbrirFoto_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(82, 157);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "GuardarFoto";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(607, 214);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAbrirFoto);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.PicFoto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEliminarContacto);
            this.Controls.Add(this.btnModificarContacto);
            this.Controls.Add(this.BtnNuevoContacto);
            this.Name = "FrmAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.FrmAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnNuevoContacto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox PicFoto;
        private System.Windows.Forms.Button btnModificarContacto;
        private System.Windows.Forms.Button BtnEliminarContacto;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Button btnAbrirFoto;
        private System.Windows.Forms.Button btnGuardar;
    }
}