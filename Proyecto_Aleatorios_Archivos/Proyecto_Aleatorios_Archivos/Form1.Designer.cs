namespace Proyecto_Aleatorios_Archivos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lista_ = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.agregar = new System.Windows.Forms.Button();
            this.edad = new System.Windows.Forms.TextBox();
            this.dire = new System.Windows.Forms.TextBox();
            this.sueldo = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buscar_datos = new System.Windows.Forms.Button();
            this.buscar_ = new System.Windows.Forms.TextBox();
            this.lbl_cambio = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lista1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eliminar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(661, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lista_);
            this.tabPage2.Controls.Add(this.agregar);
            this.tabPage2.Controls.Add(this.edad);
            this.tabPage2.Controls.Add(this.dire);
            this.tabPage2.Controls.Add(this.sueldo);
            this.tabPage2.Controls.Add(this.nom);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(653, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Agregar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lista_
            // 
            this.lista_.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lista_.Location = new System.Drawing.Point(32, 292);
            this.lista_.Name = "lista_";
            this.lista_.Size = new System.Drawing.Size(546, 96);
            this.lista_.TabIndex = 10;
            this.lista_.UseCompatibleStateImageBehavior = false;
            this.lista_.View = System.Windows.Forms.View.Details;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 136;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Edad";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Direccion";
            this.columnHeader3.Width = 236;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sueldo";
            this.columnHeader4.Width = 85;
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(11, 248);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 23);
            this.agregar.TabIndex = 9;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.button1_Click);
            this.agregar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.agregar_KeyPress);
            // 
            // edad
            // 
            this.edad.Location = new System.Drawing.Point(74, 85);
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(148, 20);
            this.edad.TabIndex = 7;
            this.edad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edad_KeyPress);
            // 
            // dire
            // 
            this.dire.Location = new System.Drawing.Point(74, 133);
            this.dire.Name = "dire";
            this.dire.Size = new System.Drawing.Size(148, 20);
            this.dire.TabIndex = 6;
            this.dire.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dire_KeyPress);
            // 
            // sueldo
            // 
            this.sueldo.Location = new System.Drawing.Point(74, 189);
            this.sueldo.Name = "sueldo";
            this.sueldo.Size = new System.Drawing.Size(148, 20);
            this.sueldo.TabIndex = 5;
            this.sueldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sueldo_KeyPress);
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(74, 34);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(148, 20);
            this.nom.TabIndex = 4;
            this.nom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nom_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sueldo :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direccion :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre :";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.eliminar);
            this.tabPage1.Controls.Add(this.lista1);
            this.tabPage1.Controls.Add(this.buscar_datos);
            this.tabPage1.Controls.Add(this.buscar_);
            this.tabPage1.Controls.Add(this.lbl_cambio);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(653, 424);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Mostrar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buscar_datos
            // 
            this.buscar_datos.Location = new System.Drawing.Point(298, 167);
            this.buscar_datos.Name = "buscar_datos";
            this.buscar_datos.Size = new System.Drawing.Size(85, 30);
            this.buscar_datos.TabIndex = 10;
            this.buscar_datos.Text = "Buscar";
            this.buscar_datos.UseVisualStyleBackColor = true;
            this.buscar_datos.Visible = false;
            this.buscar_datos.Click += new System.EventHandler(this.buscar_datos_Click);
            // 
            // buscar_
            // 
            this.buscar_.Location = new System.Drawing.Point(110, 177);
            this.buscar_.Name = "buscar_";
            this.buscar_.Size = new System.Drawing.Size(152, 20);
            this.buscar_.TabIndex = 2;
            this.buscar_.Visible = false;
            // 
            // lbl_cambio
            // 
            this.lbl_cambio.AutoSize = true;
            this.lbl_cambio.Location = new System.Drawing.Point(16, 184);
            this.lbl_cambio.Name = "lbl_cambio";
            this.lbl_cambio.Size = new System.Drawing.Size(61, 13);
            this.lbl_cambio.TabIndex = 1;
            this.lbl_cambio.Text = "Busqueda :";
            this.lbl_cambio.UseWaitCursor = true;
            this.lbl_cambio.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(19, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Metodos de Busquedas ";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(360, 55);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(93, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Mostrar Todos";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            this.radioButton3.Click += new System.EventHandler(this.radioButton3_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(184, 55);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(80, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Por  Sueldo";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(26, 55);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(79, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Por nombre";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lista1
            // 
            this.lista1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lista1.Location = new System.Drawing.Point(6, 288);
            this.lista1.Name = "lista1";
            this.lista1.Size = new System.Drawing.Size(534, 124);
            this.lista1.TabIndex = 11;
            this.lista1.UseCompatibleStateImageBehavior = false;
            this.lista1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 136;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Edad";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Direccion";
            this.columnHeader6.Width = 236;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Sueldo";
            this.columnHeader7.Width = 85;
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(558, 288);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(85, 30);
            this.eliminar.TabIndex = 12;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(558, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(558, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 30);
            this.button2.TabIndex = 14;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Archivos_Aleatorios";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.TextBox edad;
        private System.Windows.Forms.TextBox dire;
        private System.Windows.Forms.TextBox sueldo;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buscar_datos;
        private System.Windows.Forms.TextBox buscar_;
        private System.Windows.Forms.Label lbl_cambio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ListView lista_;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView lista1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

