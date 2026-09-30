namespace MDI_serializacion
{
    partial class frmPersona
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            txtNombre = new TextBox();
            txtID = new TextBox();
            txtApellido = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            cbProvincia = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            txtCiudad = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtCalle = new TextBox();
            txtNro = new TextBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            dtFechaNacimiento = new DateTimePicker();
            btoGuardar = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            dgwDatosPersona = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            FechaNacimiento = new DataGridViewTextBoxColumn();
            Calle = new DataGridViewTextBoxColumn();
            Nro = new DataGridViewTextBoxColumn();
            Ciudad = new DataGridViewTextBoxColumn();
            Provincia = new DataGridViewTextBoxColumn();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwDatosPersona).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(69, 61);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(312, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtID
            // 
            txtID.Location = new Point(69, 32);
            txtID.Name = "txtID";
            txtID.Size = new Size(104, 23);
            txtID.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(69, 90);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(312, 23);
            txtApellido.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 37);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 3;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 69);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 98);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 5;
            label3.Text = "Apellido";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbProvincia);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtCiudad);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtCalle);
            groupBox1.Controls.Add(txtNro);
            groupBox1.Location = new Point(442, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(346, 153);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dirección";
            // 
            // cbProvincia
            // 
            cbProvincia.FormattingEnabled = true;
            cbProvincia.Items.AddRange(new object[] { "Santa Fe", "Buenos Aires", "Cordoba", "Santa Cruz" });
            cbProvincia.Location = new Point(79, 107);
            cbProvincia.Name = "cbProvincia";
            cbProvincia.Size = new Size(244, 23);
            cbProvincia.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 111);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 7;
            label8.Text = "Provincia";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 81);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 6;
            label7.Text = "Ciudad";
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(79, 78);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(243, 23);
            txtCiudad.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 23);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 5;
            label6.Text = "Nro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 54);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 4;
            label5.Text = "Calle";
            label5.Click += label5_Click;
            // 
            // txtCalle
            // 
            txtCalle.Location = new Point(79, 49);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(243, 23);
            txtCalle.TabIndex = 5;
            // 
            // txtNro
            // 
            txtNro.Location = new Point(79, 20);
            txtNro.Name = "txtNro";
            txtNro.Size = new Size(100, 23);
            txtNro.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(dtFechaNacimiento);
            groupBox2.Controls.Add(txtApellido);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtID);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(18, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(399, 153);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos Personales";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 126);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 7;
            label4.Text = "F Nacim.";
            // 
            // dtFechaNacimiento
            // 
            dtFechaNacimiento.Location = new Point(69, 119);
            dtFechaNacimiento.Name = "dtFechaNacimiento";
            dtFechaNacimiento.Size = new Size(312, 23);
            dtFechaNacimiento.TabIndex = 4;
            // 
            // btoGuardar
            // 
            btoGuardar.Location = new Point(689, 185);
            btoGuardar.Name = "btoGuardar";
            btoGuardar.Size = new Size(75, 23);
            btoGuardar.TabIndex = 8;
            btoGuardar.Text = "Guardar";
            btoGuardar.UseVisualStyleBackColor = true;
            btoGuardar.Click += btoGuardar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(386, 214);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Leer Json";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(467, 214);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 10;
            button3.Text = "Guardar Json";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(563, 214);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 11;
            button4.Text = "Leer XML";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(644, 214);
            button5.Name = "button5";
            button5.Size = new Size(100, 23);
            button5.TabIndex = 12;
            button5.Text = "Guardar XML";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dgwDatosPersona
            // 
            dgwDatosPersona.AllowUserToAddRows = false;
            dgwDatosPersona.AllowUserToDeleteRows = false;
            dgwDatosPersona.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgwDatosPersona.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgwDatosPersona.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwDatosPersona.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Apellido, FechaNacimiento, Calle, Nro, Ciudad, Provincia });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgwDatosPersona.DefaultCellStyle = dataGridViewCellStyle2;
            dgwDatosPersona.Location = new Point(18, 243);
            dgwDatosPersona.Name = "dgwDatosPersona";
            dgwDatosPersona.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgwDatosPersona.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgwDatosPersona.RowTemplate.Height = 25;
            dgwDatosPersona.Size = new Size(741, 174);
            dgwDatosPersona.TabIndex = 13;
            dgwDatosPersona.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            Apellido.DataPropertyName = "apellido";
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // FechaNacimiento
            // 
            FechaNacimiento.HeaderText = "F/N";
            FechaNacimiento.Name = "FechaNacimiento";
            FechaNacimiento.ReadOnly = true;
            // 
            // Calle
            // 
            Calle.HeaderText = "Calle";
            Calle.Name = "Calle";
            Calle.ReadOnly = true;
            Calle.Width = 150;
            // 
            // Nro
            // 
            Nro.HeaderText = "Nro";
            Nro.Name = "Nro";
            Nro.ReadOnly = true;
            Nro.Width = 50;
            // 
            // Ciudad
            // 
            Ciudad.HeaderText = "Ciudad";
            Ciudad.Name = "Ciudad";
            Ciudad.ReadOnly = true;
            // 
            // Provincia
            // 
            Provincia.HeaderText = "Provincia";
            Provincia.Name = "Provincia";
            Provincia.ReadOnly = true;
            // 
            // button1
            // 
            button1.Location = new Point(23, 194);
            button1.Name = "button1";
            button1.Size = new Size(119, 23);
            button1.TabIndex = 14;
            button1.Text = "Calcular Edad";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmPersona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dgwDatosPersona);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btoGuardar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmPersona";
            Text = "ABM Persona";
            Load += frmPersona_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwDatosPersona).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtID;
        private TextBox txtApellido;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private DateTimePicker dtFechaNacimiento;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtCiudad;
        private TextBox txtNro;
        private TextBox txtCalle;
        private ComboBox cbProvincia;
        private Button btoGuardar;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private DataGridView dgwDatosPersona;
        private Button button1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn FechaNacimiento;
        private DataGridViewTextBoxColumn Calle;
        private DataGridViewTextBoxColumn Nro;
        private DataGridViewTextBoxColumn Ciudad;
        private DataGridViewTextBoxColumn Provincia;
    }
}