namespace SistemaCsharp_Pitbullnet
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.btnMensaje = new System.Windows.Forms.Button();
            this.btnListView = new System.Windows.Forms.Button();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIf = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.btnIfElse = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnDoWhile = new System.Windows.Forms.Button();
            this.btnArregloUnidimensional = new System.Windows.Forms.Button();
            this.btnArregloBidimensional = new System.Windows.Forms.Button();
            this.btnTiposDeDatos = new System.Windows.Forms.Button();
            this.btnClaseObjetosPropiedades = new System.Windows.Forms.Button();
            this.btnMetodos = new System.Windows.Forms.Button();
            this.btnPolimorfismos = new System.Windows.Forms.Button();
            this.btnGet_Set = new System.Windows.Forms.Button();
            this.btnExcepciones = new System.Windows.Forms.Button();
            this.btnHerencia = new System.Windows.Forms.Button();
            this.btnEstructuras = new System.Windows.Forms.Button();
            this.BtnListas = new System.Windows.Forms.Button();
            this.P = new System.Windows.Forms.Button();
            this.btnEnumeraciones = new System.Windows.Forms.Button();
            this.btnBorrarDatos = new System.Windows.Forms.Button();
            this.btnScope = new System.Windows.Forms.Button();
            this.btnClasesAbstractas = new System.Windows.Forms.Button();
            this.btnDelegado = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConsultarXml = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstDatos
            // 
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.Location = new System.Drawing.Point(474, 159);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(257, 173);
            this.lstDatos.TabIndex = 0;
            // 
            // btnMensaje
            // 
            this.btnMensaje.Location = new System.Drawing.Point(12, 12);
            this.btnMensaje.Name = "btnMensaje";
            this.btnMensaje.Size = new System.Drawing.Size(183, 23);
            this.btnMensaje.TabIndex = 1;
            this.btnMensaje.Text = "Mostrar Valores caja de texto";
            this.btnMensaje.UseVisualStyleBackColor = true;
            this.btnMensaje.Click += new System.EventHandler(this.btnMensaje_Click);
            // 
            // btnListView
            // 
            this.btnListView.Location = new System.Drawing.Point(12, 41);
            this.btnListView.Name = "btnListView";
            this.btnListView.Size = new System.Drawing.Size(183, 23);
            this.btnListView.TabIndex = 2;
            this.btnListView.Text = "Mostrar Valores en lstBox";
            this.btnListView.UseVisualStyleBackColor = true;
            this.btnListView.Click += new System.EventHandler(this.btnListView_Click);
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(71, 28);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(217, 20);
            this.txtValor1.TabIndex = 3;
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(71, 74);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(217, 20);
            this.txtValor2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valor1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor2";
            // 
            // btnIf
            // 
            this.btnIf.Location = new System.Drawing.Point(12, 101);
            this.btnIf.Name = "btnIf";
            this.btnIf.Size = new System.Drawing.Size(183, 23);
            this.btnIf.TabIndex = 6;
            this.btnIf.Text = "if";
            this.btnIf.UseVisualStyleBackColor = true;
            this.btnIf.Click += new System.EventHandler(this.btnIf_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(12, 159);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(183, 23);
            this.btnSwitch.TabIndex = 7;
            this.btnSwitch.Text = "Switch";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnIfElse
            // 
            this.btnIfElse.Location = new System.Drawing.Point(12, 130);
            this.btnIfElse.Name = "btnIfElse";
            this.btnIfElse.Size = new System.Drawing.Size(183, 23);
            this.btnIfElse.TabIndex = 8;
            this.btnIfElse.Text = "ifElse";
            this.btnIfElse.UseVisualStyleBackColor = true;
            this.btnIfElse.Click += new System.EventHandler(this.btnIfElse_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(12, 188);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(183, 23);
            this.btnWhile.TabIndex = 9;
            this.btnWhile.Text = "While";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnDoWhile
            // 
            this.btnDoWhile.Location = new System.Drawing.Point(12, 217);
            this.btnDoWhile.Name = "btnDoWhile";
            this.btnDoWhile.Size = new System.Drawing.Size(183, 23);
            this.btnDoWhile.TabIndex = 9;
            this.btnDoWhile.Text = "Do While";
            this.btnDoWhile.UseVisualStyleBackColor = true;
            this.btnDoWhile.Click += new System.EventHandler(this.btnDoWhile_Click);
            // 
            // btnArregloUnidimensional
            // 
            this.btnArregloUnidimensional.Location = new System.Drawing.Point(12, 246);
            this.btnArregloUnidimensional.Name = "btnArregloUnidimensional";
            this.btnArregloUnidimensional.Size = new System.Drawing.Size(183, 23);
            this.btnArregloUnidimensional.TabIndex = 10;
            this.btnArregloUnidimensional.Text = "Arreglo Unidimensional";
            this.btnArregloUnidimensional.UseVisualStyleBackColor = true;
            this.btnArregloUnidimensional.Click += new System.EventHandler(this.btnArregloUnidimensional_Click);
            // 
            // btnArregloBidimensional
            // 
            this.btnArregloBidimensional.Location = new System.Drawing.Point(12, 280);
            this.btnArregloBidimensional.Name = "btnArregloBidimensional";
            this.btnArregloBidimensional.Size = new System.Drawing.Size(183, 23);
            this.btnArregloBidimensional.TabIndex = 11;
            this.btnArregloBidimensional.Text = "Arreglo Bidimensional";
            this.btnArregloBidimensional.UseVisualStyleBackColor = true;
            this.btnArregloBidimensional.Click += new System.EventHandler(this.btnArregloBidimensional_Click);
            // 
            // btnTiposDeDatos
            // 
            this.btnTiposDeDatos.Location = new System.Drawing.Point(12, 72);
            this.btnTiposDeDatos.Name = "btnTiposDeDatos";
            this.btnTiposDeDatos.Size = new System.Drawing.Size(183, 23);
            this.btnTiposDeDatos.TabIndex = 12;
            this.btnTiposDeDatos.Text = "TiposDeDatos";
            this.btnTiposDeDatos.UseVisualStyleBackColor = true;
            this.btnTiposDeDatos.Click += new System.EventHandler(this.btnTiposDeDatos_Click);
            // 
            // btnClaseObjetosPropiedades
            // 
            this.btnClaseObjetosPropiedades.Location = new System.Drawing.Point(12, 309);
            this.btnClaseObjetosPropiedades.Name = "btnClaseObjetosPropiedades";
            this.btnClaseObjetosPropiedades.Size = new System.Drawing.Size(183, 23);
            this.btnClaseObjetosPropiedades.TabIndex = 13;
            this.btnClaseObjetosPropiedades.Text = "Clases-Objetos-Propiedades";
            this.btnClaseObjetosPropiedades.UseVisualStyleBackColor = true;
            this.btnClaseObjetosPropiedades.Click += new System.EventHandler(this.btnClaseObjetosPropiedades_Click);
            // 
            // btnMetodos
            // 
            this.btnMetodos.Location = new System.Drawing.Point(16, 338);
            this.btnMetodos.Name = "btnMetodos";
            this.btnMetodos.Size = new System.Drawing.Size(179, 23);
            this.btnMetodos.TabIndex = 14;
            this.btnMetodos.Text = "metodos-funciones";
            this.btnMetodos.UseVisualStyleBackColor = true;
            this.btnMetodos.Click += new System.EventHandler(this.btnMetodos_Click);
            // 
            // btnPolimorfismos
            // 
            this.btnPolimorfismos.Location = new System.Drawing.Point(16, 367);
            this.btnPolimorfismos.Name = "btnPolimorfismos";
            this.btnPolimorfismos.Size = new System.Drawing.Size(179, 23);
            this.btnPolimorfismos.TabIndex = 15;
            this.btnPolimorfismos.Text = "Polimorfismos";
            this.btnPolimorfismos.UseVisualStyleBackColor = true;
            this.btnPolimorfismos.Click += new System.EventHandler(this.btnPolimorfismos_Click);
            // 
            // btnGet_Set
            // 
            this.btnGet_Set.Location = new System.Drawing.Point(16, 396);
            this.btnGet_Set.Name = "btnGet_Set";
            this.btnGet_Set.Size = new System.Drawing.Size(179, 23);
            this.btnGet_Set.TabIndex = 16;
            this.btnGet_Set.Text = "Get-Set";
            this.btnGet_Set.UseVisualStyleBackColor = true;
            this.btnGet_Set.Click += new System.EventHandler(this.btnGet_Set_Click);
            // 
            // btnExcepciones
            // 
            this.btnExcepciones.Location = new System.Drawing.Point(16, 425);
            this.btnExcepciones.Name = "btnExcepciones";
            this.btnExcepciones.Size = new System.Drawing.Size(179, 23);
            this.btnExcepciones.TabIndex = 17;
            this.btnExcepciones.Text = "Excepciones";
            this.btnExcepciones.UseVisualStyleBackColor = true;
            this.btnExcepciones.Click += new System.EventHandler(this.btnExcepciones_Click_1);
            // 
            // btnHerencia
            // 
            this.btnHerencia.Location = new System.Drawing.Point(207, 41);
            this.btnHerencia.Name = "btnHerencia";
            this.btnHerencia.Size = new System.Drawing.Size(185, 23);
            this.btnHerencia.TabIndex = 18;
            this.btnHerencia.Text = "Herencia";
            this.btnHerencia.UseVisualStyleBackColor = true;
            this.btnHerencia.Click += new System.EventHandler(this.btnHerencia_Click);
            // 
            // btnEstructuras
            // 
            this.btnEstructuras.Location = new System.Drawing.Point(207, 69);
            this.btnEstructuras.Name = "btnEstructuras";
            this.btnEstructuras.Size = new System.Drawing.Size(185, 23);
            this.btnEstructuras.TabIndex = 19;
            this.btnEstructuras.Text = "Estructuras";
            this.btnEstructuras.UseVisualStyleBackColor = true;
            this.btnEstructuras.Click += new System.EventHandler(this.btnEstructuras_Click);
            // 
            // BtnListas
            // 
            this.BtnListas.Location = new System.Drawing.Point(207, 100);
            this.BtnListas.Name = "BtnListas";
            this.BtnListas.Size = new System.Drawing.Size(185, 23);
            this.BtnListas.TabIndex = 20;
            this.BtnListas.Text = "Listas";
            this.BtnListas.UseVisualStyleBackColor = true;
            this.BtnListas.Click += new System.EventHandler(this.BtnListas_Click);
            // 
            // P
            // 
            this.P.Location = new System.Drawing.Point(207, 129);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(185, 23);
            this.P.TabIndex = 21;
            this.P.Text = "ArrayList";
            this.P.UseVisualStyleBackColor = true;
            this.P.Click += new System.EventHandler(this.P_Click);
            // 
            // btnEnumeraciones
            // 
            this.btnEnumeraciones.Location = new System.Drawing.Point(207, 12);
            this.btnEnumeraciones.Name = "btnEnumeraciones";
            this.btnEnumeraciones.Size = new System.Drawing.Size(185, 23);
            this.btnEnumeraciones.TabIndex = 22;
            this.btnEnumeraciones.Text = "Enumeraciones";
            this.btnEnumeraciones.UseVisualStyleBackColor = true;
            this.btnEnumeraciones.Click += new System.EventHandler(this.btnEnumeraciones_Click);
            // 
            // btnBorrarDatos
            // 
            this.btnBorrarDatos.Location = new System.Drawing.Point(547, 367);
            this.btnBorrarDatos.Name = "btnBorrarDatos";
            this.btnBorrarDatos.Size = new System.Drawing.Size(136, 23);
            this.btnBorrarDatos.TabIndex = 23;
            this.btnBorrarDatos.Text = "BorrarDatos";
            this.btnBorrarDatos.UseVisualStyleBackColor = true;
            this.btnBorrarDatos.Click += new System.EventHandler(this.btnBorrarDatos_Click);
            // 
            // btnScope
            // 
            this.btnScope.Location = new System.Drawing.Point(207, 159);
            this.btnScope.Name = "btnScope";
            this.btnScope.Size = new System.Drawing.Size(185, 23);
            this.btnScope.TabIndex = 25;
            this.btnScope.Text = "Scope";
            this.btnScope.UseVisualStyleBackColor = true;
            this.btnScope.Click += new System.EventHandler(this.btnScope_Click);
            // 
            // btnClasesAbstractas
            // 
            this.btnClasesAbstractas.Location = new System.Drawing.Point(207, 188);
            this.btnClasesAbstractas.Name = "btnClasesAbstractas";
            this.btnClasesAbstractas.Size = new System.Drawing.Size(185, 23);
            this.btnClasesAbstractas.TabIndex = 26;
            this.btnClasesAbstractas.Text = "Clases Abstractas";
            this.btnClasesAbstractas.UseVisualStyleBackColor = true;
            this.btnClasesAbstractas.Click += new System.EventHandler(this.btnClasesAbstractas_Click);
            // 
            // btnDelegado
            // 
            this.btnDelegado.Location = new System.Drawing.Point(207, 217);
            this.btnDelegado.Name = "btnDelegado";
            this.btnDelegado.Size = new System.Drawing.Size(185, 23);
            this.btnDelegado.TabIndex = 27;
            this.btnDelegado.Text = "Delegados";
            this.btnDelegado.UseVisualStyleBackColor = true;
            this.btnDelegado.Click += new System.EventHandler(this.btnDelegado_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtValor2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtValor1);
            this.groupBox1.Location = new System.Drawing.Point(459, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 118);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar Valores";
            // 
            // btnConsultarXml
            // 
            this.btnConsultarXml.Location = new System.Drawing.Point(207, 246);
            this.btnConsultarXml.Name = "btnConsultarXml";
            this.btnConsultarXml.Size = new System.Drawing.Size(185, 23);
            this.btnConsultarXml.TabIndex = 29;
            this.btnConsultarXml.Text = "Crear Xml";
            this.btnConsultarXml.UseVisualStyleBackColor = true;
            this.btnConsultarXml.Click += new System.EventHandler(this.btnConsultarXml_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 474);
            this.Controls.Add(this.btnConsultarXml);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelegado);
            this.Controls.Add(this.btnClasesAbstractas);
            this.Controls.Add(this.btnScope);
            this.Controls.Add(this.btnBorrarDatos);
            this.Controls.Add(this.btnEnumeraciones);
            this.Controls.Add(this.P);
            this.Controls.Add(this.BtnListas);
            this.Controls.Add(this.btnEstructuras);
            this.Controls.Add(this.btnHerencia);
            this.Controls.Add(this.btnExcepciones);
            this.Controls.Add(this.btnGet_Set);
            this.Controls.Add(this.btnPolimorfismos);
            this.Controls.Add(this.btnMetodos);
            this.Controls.Add(this.btnClaseObjetosPropiedades);
            this.Controls.Add(this.btnTiposDeDatos);
            this.Controls.Add(this.btnArregloBidimensional);
            this.Controls.Add(this.btnArregloUnidimensional);
            this.Controls.Add(this.btnDoWhile);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.btnIfElse);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.btnIf);
            this.Controls.Add(this.btnListView);
            this.Controls.Add(this.btnMensaje);
            this.Controls.Add(this.lstDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema VisualNet";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstDatos;
        private System.Windows.Forms.Button btnMensaje;
        private System.Windows.Forms.Button btnListView;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIf;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Button btnIfElse;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnDoWhile;
        private System.Windows.Forms.Button btnArregloUnidimensional;
        private System.Windows.Forms.Button btnArregloBidimensional;
        private System.Windows.Forms.Button btnTiposDeDatos;
        private System.Windows.Forms.Button btnClaseObjetosPropiedades;
        private System.Windows.Forms.Button btnMetodos;
        private System.Windows.Forms.Button btnPolimorfismos;
        private System.Windows.Forms.Button btnGet_Set;
        private System.Windows.Forms.Button btnExcepciones;
        private System.Windows.Forms.Button btnHerencia;
        private System.Windows.Forms.Button btnEstructuras;
        private System.Windows.Forms.Button BtnListas;
        private System.Windows.Forms.Button P;
        private System.Windows.Forms.Button btnEnumeraciones;
        private System.Windows.Forms.Button btnBorrarDatos;
        private System.Windows.Forms.Button btnScope;
        private System.Windows.Forms.Button btnClasesAbstractas;
        private System.Windows.Forms.Button btnDelegado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConsultarXml;
    }
}

