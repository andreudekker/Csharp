namespace SistemaCsharp_Pitbullnet
{
    partial class frmLinq
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
            this.BtnLinqConsultarArray = new System.Windows.Forms.Button();
            this.btnConsultarUnArraylist = new System.Windows.Forms.Button();
            this.btnConsultarSqlServer = new System.Windows.Forms.Button();
            this.lstDatosLinq = new System.Windows.Forms.ListBox();
            this.cboBuscarLinq = new System.Windows.Forms.ComboBox();
            this.btnConsultarLista = new System.Windows.Forms.Button();
            this.btnLimpiarDatos = new System.Windows.Forms.Button();
            this.btnConsultarXML_Linq = new System.Windows.Forms.Button();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresadePruebaDataSet = new SistemaCsharp_Pitbullnet.EmpresadePruebaDataSet();
            this.usuarioTableAdapter = new SistemaCsharp_Pitbullnet.EmpresadePruebaDataSetTableAdapters.UsuarioTableAdapter();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.BtnBorrarSQL = new System.Windows.Forms.Button();
            this.btnNuevoLinq = new System.Windows.Forms.Button();
            this.btnEditarLinq = new System.Windows.Forms.Button();
            this.txtNombreLinq = new System.Windows.Forms.TextBox();
            this.txtTelefonoLinq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMostrarLinq = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresadePruebaDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnLinqConsultarArray
            // 
            this.BtnLinqConsultarArray.Location = new System.Drawing.Point(12, 19);
            this.BtnLinqConsultarArray.Name = "BtnLinqConsultarArray";
            this.BtnLinqConsultarArray.Size = new System.Drawing.Size(148, 23);
            this.BtnLinqConsultarArray.TabIndex = 0;
            this.BtnLinqConsultarArray.Text = "Consultar Un Array";
            this.BtnLinqConsultarArray.UseVisualStyleBackColor = true;
            this.BtnLinqConsultarArray.Click += new System.EventHandler(this.BtnLinqConsultarArray_Click);
            // 
            // btnConsultarUnArraylist
            // 
            this.btnConsultarUnArraylist.Location = new System.Drawing.Point(174, 19);
            this.btnConsultarUnArraylist.Name = "btnConsultarUnArraylist";
            this.btnConsultarUnArraylist.Size = new System.Drawing.Size(148, 23);
            this.btnConsultarUnArraylist.TabIndex = 1;
            this.btnConsultarUnArraylist.Text = "Consultar Un Array list";
            this.btnConsultarUnArraylist.UseVisualStyleBackColor = true;
            this.btnConsultarUnArraylist.Click += new System.EventHandler(this.btnConsultarUnArraylist_Click);
            // 
            // btnConsultarSqlServer
            // 
            this.btnConsultarSqlServer.Location = new System.Drawing.Point(90, 77);
            this.btnConsultarSqlServer.Name = "btnConsultarSqlServer";
            this.btnConsultarSqlServer.Size = new System.Drawing.Size(148, 41);
            this.btnConsultarSqlServer.TabIndex = 3;
            this.btnConsultarSqlServer.Text = "Consultar SqlServer a listbox";
            this.btnConsultarSqlServer.UseVisualStyleBackColor = true;
            this.btnConsultarSqlServer.Click += new System.EventHandler(this.btnConsultarSqlServer_Click);
            // 
            // lstDatosLinq
            // 
            this.lstDatosLinq.FormattingEnabled = true;
            this.lstDatosLinq.Location = new System.Drawing.Point(360, 12);
            this.lstDatosLinq.Name = "lstDatosLinq";
            this.lstDatosLinq.Size = new System.Drawing.Size(299, 342);
            this.lstDatosLinq.TabIndex = 4;
            // 
            // cboBuscarLinq
            // 
            this.cboBuscarLinq.FormattingEnabled = true;
            this.cboBuscarLinq.Location = new System.Drawing.Point(56, 27);
            this.cboBuscarLinq.Name = "cboBuscarLinq";
            this.cboBuscarLinq.Size = new System.Drawing.Size(100, 21);
            this.cboBuscarLinq.TabIndex = 5;
            // 
            // btnConsultarLista
            // 
            this.btnConsultarLista.Location = new System.Drawing.Point(11, 43);
            this.btnConsultarLista.Name = "btnConsultarLista";
            this.btnConsultarLista.Size = new System.Drawing.Size(148, 23);
            this.btnConsultarLista.TabIndex = 6;
            this.btnConsultarLista.Text = "Consultar Una lista";
            this.btnConsultarLista.UseVisualStyleBackColor = true;
            this.btnConsultarLista.Click += new System.EventHandler(this.btnConsultarLista_Click);
            // 
            // btnLimpiarDatos
            // 
            this.btnLimpiarDatos.Location = new System.Drawing.Point(533, 360);
            this.btnLimpiarDatos.Name = "btnLimpiarDatos";
            this.btnLimpiarDatos.Size = new System.Drawing.Size(126, 23);
            this.btnLimpiarDatos.TabIndex = 7;
            this.btnLimpiarDatos.Text = "Borrar  Datos";
            this.btnLimpiarDatos.UseVisualStyleBackColor = true;
            this.btnLimpiarDatos.Click += new System.EventHandler(this.btnLimpiarDatos_Click);
            // 
            // btnConsultarXML_Linq
            // 
            this.btnConsultarXML_Linq.Location = new System.Drawing.Point(174, 48);
            this.btnConsultarXML_Linq.Name = "btnConsultarXML_Linq";
            this.btnConsultarXML_Linq.Size = new System.Drawing.Size(153, 23);
            this.btnConsultarXML_Linq.TabIndex = 9;
            this.btnConsultarXML_Linq.Text = "Consultar XML desde Linq";
            this.btnConsultarXML_Linq.UseVisualStyleBackColor = true;
            this.btnConsultarXML_Linq.Click += new System.EventHandler(this.btnConsultarXML_Linq_Click);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.empresadePruebaDataSet;
            // 
            // empresadePruebaDataSet
            // 
            this.empresadePruebaDataSet.DataSetName = "EmpresadePruebaDataSet";
            this.empresadePruebaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(163, 25);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(163, 23);
            this.btnCargar.TabIndex = 20;
            this.btnCargar.Text = "Cargar Datos De la Busqueda";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(192, 176);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 19;
            this.btnGrabar.Text = "Guardar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // BtnBorrarSQL
            // 
            this.BtnBorrarSQL.Location = new System.Drawing.Point(273, 176);
            this.BtnBorrarSQL.Name = "BtnBorrarSQL";
            this.BtnBorrarSQL.Size = new System.Drawing.Size(75, 23);
            this.BtnBorrarSQL.TabIndex = 18;
            this.BtnBorrarSQL.Text = "Borrar";
            this.BtnBorrarSQL.UseVisualStyleBackColor = true;
            this.BtnBorrarSQL.Click += new System.EventHandler(this.BtnBorrarSQL_Click);
            // 
            // btnNuevoLinq
            // 
            this.btnNuevoLinq.Location = new System.Drawing.Point(38, 176);
            this.btnNuevoLinq.Name = "btnNuevoLinq";
            this.btnNuevoLinq.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoLinq.TabIndex = 17;
            this.btnNuevoLinq.Text = "Nuevo";
            this.btnNuevoLinq.UseVisualStyleBackColor = true;
       
            // 
            // btnEditarLinq
            // 
            this.btnEditarLinq.Location = new System.Drawing.Point(116, 176);
            this.btnEditarLinq.Name = "btnEditarLinq";
            this.btnEditarLinq.Size = new System.Drawing.Size(75, 23);
            this.btnEditarLinq.TabIndex = 16;
            this.btnEditarLinq.Text = "Editar";
            this.btnEditarLinq.UseVisualStyleBackColor = true;
            this.btnEditarLinq.Click += new System.EventHandler(this.btnEditarLinq_Click);
            // 
            // txtNombreLinq
            // 
            this.txtNombreLinq.Location = new System.Drawing.Point(56, 54);
            this.txtNombreLinq.Name = "txtNombreLinq";
            this.txtNombreLinq.Size = new System.Drawing.Size(100, 20);
            this.txtNombreLinq.TabIndex = 21;
            // 
            // txtTelefonoLinq
            // 
            this.txtTelefonoLinq.Location = new System.Drawing.Point(56, 80);
            this.txtTelefonoLinq.Name = "txtTelefonoLinq";
            this.txtTelefonoLinq.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonoLinq.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Buscar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCargar);
            this.groupBox1.Controls.Add(this.btnMostrarLinq);
            this.groupBox1.Controls.Add(this.txtNombreLinq);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTelefonoLinq);
            this.groupBox1.Controls.Add(this.cboBuscarLinq);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 128);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DatosLinq";
            // 
            // btnMostrarLinq
            // 
            this.btnMostrarLinq.Location = new System.Drawing.Point(169, 97);
            this.btnMostrarLinq.Name = "btnMostrarLinq";
            this.btnMostrarLinq.Size = new System.Drawing.Size(147, 23);
            this.btnMostrarLinq.TabIndex = 26;
            this.btnMostrarLinq.Text = "Mostrar Datos de la BD";
            this.btnMostrarLinq.UseVisualStyleBackColor = true;
            this.btnMostrarLinq.Click += new System.EventHandler(this.btnMostrarLinq_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnLinqConsultarArray);
            this.groupBox2.Controls.Add(this.btnConsultarLista);
            this.groupBox2.Controls.Add(this.btnConsultarXML_Linq);
            this.groupBox2.Controls.Add(this.btnConsultarUnArraylist);
            this.groupBox2.Controls.Add(this.btnConsultarSqlServer);
            this.groupBox2.Location = new System.Drawing.Point(5, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 131);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consultas Linq";
            // 
            // frmLinq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 413);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.BtnBorrarSQL);
            this.Controls.Add(this.btnNuevoLinq);
            this.Controls.Add(this.btnEditarLinq);
            this.Controls.Add(this.btnLimpiarDatos);
            this.Controls.Add(this.lstDatosLinq);
            this.Name = "frmLinq";
            this.Text = " Consultas Linq";
            this.Load += new System.EventHandler(this.frmLinq_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresadePruebaDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLinqConsultarArray;
        private System.Windows.Forms.Button btnConsultarUnArraylist;
        private System.Windows.Forms.Button btnConsultarSqlServer;
        private System.Windows.Forms.ListBox lstDatosLinq;
        private System.Windows.Forms.ComboBox cboBuscarLinq;
        private System.Windows.Forms.Button btnConsultarLista;
        private System.Windows.Forms.Button btnLimpiarDatos;
        private System.Windows.Forms.Button btnConsultarXML_Linq;
        private EmpresadePruebaDataSet empresadePruebaDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private EmpresadePruebaDataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button BtnBorrarSQL;
        private System.Windows.Forms.Button btnNuevoLinq;
        private System.Windows.Forms.Button btnEditarLinq;
        private System.Windows.Forms.TextBox txtNombreLinq;
        private System.Windows.Forms.TextBox txtTelefonoLinq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMostrarLinq;
    }
}