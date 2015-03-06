namespace Pacman
{
    partial class frmPacman
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
            this.picPacman = new System.Windows.Forms.PictureBox();
            this.TmPacman = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picPacman)).BeginInit();
            this.SuspendLayout();
            // 
            // picPacman
            // 
            this.picPacman.Image = global::Pacman.Properties.Resources._1051897_pacman;
            this.picPacman.Location = new System.Drawing.Point(12, 27);
            this.picPacman.Name = "picPacman";
            this.picPacman.Size = new System.Drawing.Size(84, 58);
            this.picPacman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPacman.TabIndex = 0;
            this.picPacman.TabStop = false;
            // 
            // TmPacman
            // 
            this.TmPacman.Enabled = true;
            this.TmPacman.Tick += new System.EventHandler(this.TmPacman_Tick);
            // 
            // frmPacman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(565, 397);
            this.Controls.Add(this.picPacman);
            this.Name = "frmPacman";
            this.Text = "Pacman";
            this.Load += new System.EventHandler(this.frmPacman_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPacman_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picPacman)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPacman;
        private System.Windows.Forms.Timer TmPacman;
    }
}

