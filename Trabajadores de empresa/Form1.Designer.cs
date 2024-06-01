namespace Trabajadores_de_empresa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nombre = new TextBox();
            apellidop = new TextBox();
            apellidom = new TextBox();
            fechatxt = new DateTimePicker();
            puestocb = new ComboBox();
            correotxt = new TextBox();
            curptxt = new TextBox();
            rfctxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            telefonotxt = new TextBox();
            label10 = new Label();
            EDADtxt = new TextBox();
            button1 = new Button();
            Horascb = new ComboBox();
            label12 = new Label();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            Datostrabajador = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            label14 = new Label();
            label15 = new Label();
            ((System.ComponentModel.ISupportInitialize)Datostrabajador).BeginInit();
            SuspendLayout();
            // 
            // nombre
            // 
            nombre.Location = new Point(12, 62);
            nombre.Name = "nombre";
            nombre.Size = new Size(173, 23);
            nombre.TabIndex = 0;
            // 
            // apellidop
            // 
            apellidop.Location = new Point(12, 125);
            apellidop.Name = "apellidop";
            apellidop.Size = new Size(173, 23);
            apellidop.TabIndex = 1;
            // 
            // apellidom
            // 
            apellidom.Location = new Point(12, 191);
            apellidom.Name = "apellidom";
            apellidom.Size = new Size(173, 23);
            apellidom.TabIndex = 2;
            // 
            // fechatxt
            // 
            fechatxt.Location = new Point(12, 338);
            fechatxt.Name = "fechatxt";
            fechatxt.Size = new Size(200, 23);
            fechatxt.TabIndex = 3;
            // 
            // puestocb
            // 
            puestocb.FormattingEnabled = true;
            puestocb.Items.AddRange(new object[] { "Operario", "Supervisor", "Vicepresidente" });
            puestocb.Location = new Point(13, 398);
            puestocb.Name = "puestocb";
            puestocb.Size = new Size(121, 23);
            puestocb.TabIndex = 4;
            puestocb.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // correotxt
            // 
            correotxt.Location = new Point(237, 191);
            correotxt.Name = "correotxt";
            correotxt.Size = new Size(174, 23);
            correotxt.TabIndex = 5;
            // 
            // curptxt
            // 
            curptxt.Location = new Point(237, 61);
            curptxt.Name = "curptxt";
            curptxt.Size = new Size(174, 23);
            curptxt.TabIndex = 6;
            // 
            // rfctxt
            // 
            rfctxt.Location = new Point(237, 125);
            rfctxt.Name = "rfctxt";
            rfctxt.Size = new Size(174, 23);
            rfctxt.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 8;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 107);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 9;
            label2.Text = "Apellido Paterno:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 173);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 10;
            label3.Text = "Appellido Materno:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 320);
            label4.Name = "label4";
            label4.Size = new Size(122, 15);
            label4.TabIndex = 11;
            label4.Text = "Fecha de Nacimiento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 380);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 12;
            label5.Text = "Puesto de trabajo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(236, 173);
            label6.Name = "label6";
            label6.Size = new Size(108, 15);
            label6.TabIndex = 13;
            label6.Text = "Correo Electronico:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(237, 44);
            label7.Name = "label7";
            label7.Size = new Size(37, 15);
            label7.TabIndex = 14;
            label7.Text = "CURP";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(237, 107);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 15;
            label8.Text = "RFC";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(237, 250);
            label9.Name = "label9";
            label9.Size = new Size(111, 15);
            label9.TabIndex = 16;
            label9.Text = "Numero Telefonico:";
            // 
            // telefonotxt
            // 
            telefonotxt.Location = new Point(238, 268);
            telefonotxt.Name = "telefonotxt";
            telefonotxt.Size = new Size(173, 23);
            telefonotxt.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 250);
            label10.Name = "label10";
            label10.Size = new Size(36, 15);
            label10.TabIndex = 18;
            label10.Text = "Edad:";
            // 
            // EDADtxt
            // 
            EDADtxt.Location = new Point(12, 268);
            EDADtxt.Name = "EDADtxt";
            EDADtxt.Size = new Size(173, 23);
            EDADtxt.TabIndex = 19;
            // 
            // button1
            // 
            button1.Location = new Point(13, 514);
            button1.Name = "button1";
            button1.Size = new Size(122, 23);
            button1.TabIndex = 20;
            button1.Text = "Guardar Empleado";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Horascb
            // 
            Horascb.FormattingEnabled = true;
            Horascb.Items.AddRange(new object[] { "2 horas", "4 horas", "5 horas", "6 horas", "7 horas", "8 horas " });
            Horascb.Location = new Point(237, 398);
            Horascb.Name = "Horascb";
            Horascb.Size = new Size(121, 23);
            Horascb.TabIndex = 23;
            Horascb.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(238, 380);
            label12.Name = "label12";
            label12.Size = new Size(94, 15);
            label12.TabIndex = 24;
            label12.Text = "Horas de trabajo";
            // 
            // button2
            // 
            button2.Location = new Point(540, 60);
            button2.Name = "button2";
            button2.Size = new Size(139, 23);
            button2.TabIndex = 26;
            button2.Text = "Cargar empleados";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(540, 125);
            button4.Name = "button4";
            button4.Size = new Size(139, 23);
            button4.TabIndex = 30;
            button4.Text = "Borrar empleado";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(178, 514);
            button5.Name = "button5";
            button5.Size = new Size(96, 23);
            button5.TabIndex = 31;
            button5.Text = "Guardar como";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Datostrabajador
            // 
            Datostrabajador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Datostrabajador.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12 });
            Datostrabajador.Location = new Point(685, 12);
            Datostrabajador.Name = "Datostrabajador";
            Datostrabajador.Size = new Size(753, 594);
            Datostrabajador.TabIndex = 32;
            // 
            // Column1
            // 
            Column1.HeaderText = "#Nombre";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "#ApellidoPaterno";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "#ApellidoMaterno";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "#Edad";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "#Fecha de nacimiento";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "#CURP";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "#RFC";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "#Correo Electronico";
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "#Numero telefonico";
            Column9.Name = "Column9";
            // 
            // Column10
            // 
            Column10.HeaderText = "#Puesto de trabajo";
            Column10.Name = "Column10";
            // 
            // Column11
            // 
            Column11.HeaderText = "#Horas  Trabajadas";
            Column11.Name = "Column11";
            // 
            // Column12
            // 
            Column12.HeaderText = "#Sueldo";
            Column12.Name = "Column12";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.Control;
            label14.ForeColor = SystemColors.Control;
            label14.Location = new Point(12, 424);
            label14.Name = "label14";
            label14.Size = new Size(44, 15);
            label14.TabIndex = 33;
            label14.Text = "label14";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = SystemColors.Control;
            label15.Location = new Point(238, 424);
            label15.Name = "label15";
            label15.Size = new Size(44, 15);
            label15.TabIndex = 34;
            label15.Text = "label15";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1450, 618);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(Datostrabajador);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(label12);
            Controls.Add(Horascb);
            Controls.Add(button1);
            Controls.Add(EDADtxt);
            Controls.Add(label10);
            Controls.Add(telefonotxt);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rfctxt);
            Controls.Add(curptxt);
            Controls.Add(correotxt);
            Controls.Add(puestocb);
            Controls.Add(fechatxt);
            Controls.Add(apellidom);
            Controls.Add(apellidop);
            Controls.Add(nombre);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)Datostrabajador).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nombre;
        private TextBox apellidop;
        private TextBox apellidom;
        private DateTimePicker fechatxt;
        private ComboBox puestocb;
        private TextBox correotxt;
        private TextBox curptxt;
        private TextBox rfctxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox telefonotxt;
        private Label label10;
        private TextBox EDADtxt;
        private Button button1;
        private ComboBox Horascb;
        private Label label12;
        private Button button2;
        private Button button4;
        private Button button5;
        private DataGridView Datostrabajador;
        private Label label14;
        private Label label15;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
    }
}
