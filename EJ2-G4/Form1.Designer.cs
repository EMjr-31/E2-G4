namespace EJ2_G4
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
            this.Datos = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCarreras = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHorasT = new System.Windows.Forms.TextBox();
            this.txtMat1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMat2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMat3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtHorasCompl = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtProyecto = new System.Windows.Forms.TextBox();
            this.dgvIngenieria = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbmUniversidades = new System.Windows.Forms.ComboBox();
            this.Estadisticas = new System.Windows.Forms.GroupBox();
            this.btnEstudientes = new System.Windows.Forms.Button();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Datos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngenieria)).BeginInit();
            this.Estadisticas.SuspendLayout();
            this.SuspendLayout();
            // 
            // Datos
            // 
            this.Datos.Controls.Add(this.groupBox4);
            this.Datos.Controls.Add(this.btnGuardar);
            this.Datos.Controls.Add(this.groupBox3);
            this.Datos.Controls.Add(this.btnEliminar);
            this.Datos.Controls.Add(this.groupBox2);
            this.Datos.Controls.Add(this.groupBox1);
            this.Datos.Location = new System.Drawing.Point(12, 12);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(776, 294);
            this.Datos.TabIndex = 0;
            this.Datos.TabStop = false;
            this.Datos.Text = "Datos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personales";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbmUniversidades);
            this.groupBox2.Controls.Add(this.txtProyecto);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtNivel);
            this.groupBox2.Controls.Add(this.txtCarnet);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.cmbCarreras);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(6, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 161);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Universidad";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(75, 28);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(259, 28);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Universidad: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Carrera:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmbCarreras
            // 
            this.cmbCarreras.FormattingEnabled = true;
            this.cmbCarreras.Location = new System.Drawing.Point(75, 77);
            this.cmbCarreras.Name = "cmbCarreras";
            this.cmbCarreras.Size = new System.Drawing.Size(116, 21);
            this.cmbCarreras.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNota3);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtNota2);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtNota1);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtMat3);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtMat2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtMat1);
            this.groupBox3.Location = new System.Drawing.Point(403, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(367, 160);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Materias Inscritas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Horas Totales:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Materia 1: ";
            // 
            // txtHorasT
            // 
            this.txtHorasT.Location = new System.Drawing.Point(88, 29);
            this.txtHorasT.Name = "txtHorasT";
            this.txtHorasT.Size = new System.Drawing.Size(64, 20);
            this.txtHorasT.TabIndex = 1;
            // 
            // txtMat1
            // 
            this.txtMat1.Location = new System.Drawing.Point(69, 28);
            this.txtMat1.Name = "txtMat1";
            this.txtMat1.Size = new System.Drawing.Size(100, 20);
            this.txtMat1.TabIndex = 0;
            this.txtMat1.Text = "Matematicas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Materia 2: ";
            // 
            // txtMat2
            // 
            this.txtMat2.Location = new System.Drawing.Point(69, 69);
            this.txtMat2.Name = "txtMat2";
            this.txtMat2.Size = new System.Drawing.Size(100, 20);
            this.txtMat2.TabIndex = 4;
            this.txtMat2.Text = "Ciencias";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Materia 3: ";
            // 
            // txtMat3
            // 
            this.txtMat3.Location = new System.Drawing.Point(69, 107);
            this.txtMat3.Name = "txtMat3";
            this.txtMat3.Size = new System.Drawing.Size(100, 20);
            this.txtMat3.TabIndex = 6;
            this.txtMat3.Text = "Linguistica";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(176, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = ">";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(177, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = ">";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(177, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = ">";
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(246, 108);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(100, 20);
            this.txtNota3.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(198, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Nota 3:";
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(249, 69);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(100, 20);
            this.txtNota2.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(198, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Nota 2: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(198, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Nota 1: ";
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(249, 25);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(100, 20);
            this.txtNota1.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(176, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Horas Compeltadas:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // txtHorasCompl
            // 
            this.txtHorasCompl.Location = new System.Drawing.Point(288, 29);
            this.txtHorasCompl.Name = "txtHorasCompl";
            this.txtHorasCompl.Size = new System.Drawing.Size(57, 20);
            this.txtHorasCompl.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.txtHorasCompl);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtHorasT);
            this.groupBox4.Location = new System.Drawing.Point(403, 185);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(367, 67);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pasantias";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(206, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "Carnet: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(206, 80);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "Nivel: ";
            // 
            // txtCarnet
            // 
            this.txtCarnet.Location = new System.Drawing.Point(259, 35);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(100, 20);
            this.txtCarnet.TabIndex = 8;
            // 
            // txtNivel
            // 
            this.txtNivel.Location = new System.Drawing.Point(259, 73);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(100, 20);
            this.txtNivel.TabIndex = 9;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 123);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 13);
            this.label18.TabIndex = 10;
            this.label18.Text = "Proyecto:";
            // 
            // txtProyecto
            // 
            this.txtProyecto.Location = new System.Drawing.Point(70, 126);
            this.txtProyecto.Name = "txtProyecto";
            this.txtProyecto.Size = new System.Drawing.Size(264, 20);
            this.txtProyecto.TabIndex = 11;
            this.txtProyecto.TextChanged += new System.EventHandler(this.textBox14_TextChanged);
            // 
            // dgvIngenieria
            // 
            this.dgvIngenieria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngenieria.Location = new System.Drawing.Point(12, 321);
            this.dgvIngenieria.Name = "dgvIngenieria";
            this.dgvIngenieria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIngenieria.Size = new System.Drawing.Size(776, 260);
            this.dgvIngenieria.TabIndex = 1;
            this.dgvIngenieria.DoubleClick += new System.EventHandler(this.dgvIngenieria_DoubleClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(568, 261);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(677, 261);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbmUniversidades
            // 
            this.cbmUniversidades.FormattingEnabled = true;
            this.cbmUniversidades.Location = new System.Drawing.Point(75, 30);
            this.cbmUniversidades.Name = "cbmUniversidades";
            this.cbmUniversidades.Size = new System.Drawing.Size(121, 21);
            this.cbmUniversidades.TabIndex = 12;
            // 
            // Estadisticas
            // 
            this.Estadisticas.Controls.Add(this.btnPromedio);
            this.Estadisticas.Controls.Add(this.btnEstudientes);
            this.Estadisticas.Location = new System.Drawing.Point(12, 593);
            this.Estadisticas.Name = "Estadisticas";
            this.Estadisticas.Size = new System.Drawing.Size(776, 56);
            this.Estadisticas.TabIndex = 4;
            this.Estadisticas.TabStop = false;
            this.Estadisticas.Text = "Estadsiticas:";
            // 
            // btnEstudientes
            // 
            this.btnEstudientes.Location = new System.Drawing.Point(98, 19);
            this.btnEstudientes.Name = "btnEstudientes";
            this.btnEstudientes.Size = new System.Drawing.Size(204, 23);
            this.btnEstudientes.TabIndex = 0;
            this.btnEstudientes.Text = "Cantidad de Estudiantes";
            this.btnEstudientes.UseVisualStyleBackColor = true;
            this.btnEstudientes.Click += new System.EventHandler(this.btnEstudientes_Click);
            // 
            // btnPromedio
            // 
            this.btnPromedio.Location = new System.Drawing.Point(523, 19);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(204, 23);
            this.btnPromedio.TabIndex = 1;
            this.btnPromedio.Text = "Nota Promedio ";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(713, 652);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 679);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.Estadisticas);
            this.Controls.Add(this.dgvIngenieria);
            this.Controls.Add(this.Datos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Datos.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngenieria)).EndInit();
            this.Estadisticas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Datos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtHorasCompl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHorasT;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMat3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMat2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMat1;
        private System.Windows.Forms.TextBox txtProyecto;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtNivel;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbCarreras;
        private System.Windows.Forms.DataGridView dgvIngenieria;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cbmUniversidades;
        private System.Windows.Forms.GroupBox Estadisticas;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.Button btnEstudientes;
        private System.Windows.Forms.Button btnSalir;
    }
}

