namespace CapaDePresentacion
{
    partial class testABMEmpleados
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
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnGuardarCliente = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtBoxDNI = new System.Windows.Forms.TextBox();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lbldni = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDatosPersonales = new System.Windows.Forms.Label();
            this.lblDatosLaborales = new System.Windows.Forms.Label();
            this.lblCuil = new System.Windows.Forms.Label();
            this.txtBoxCuil = new System.Windows.Forms.TextBox();
            this.comBoxCargo = new System.Windows.Forms.ComboBox();
            this.ColNombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCuil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColApellidoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDNICliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPasswordCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSeleccionarCliente = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Location = new System.Drawing.Point(867, 494);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCliente.TabIndex = 38;
            this.btnEliminarCliente.Text = "Eliminar";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(867, 303);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCliente.TabIndex = 36;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.Location = new System.Drawing.Point(767, 303);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Size = new System.Drawing.Size(70, 23);
            this.btnGuardarCliente.TabIndex = 37;
            this.btnGuardarCliente.Text = "Guardar";
            this.btnGuardarCliente.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNombreCliente,
            this.ColCuil,
            this.ColCargo,
            this.ColApellidoCliente,
            this.ColFechaNac,
            this.ColDNICliente,
            this.ColEmail,
            this.ColPasswordCliente,
            this.ColSeleccionarCliente});
            this.dataGridView1.Location = new System.Drawing.Point(109, 368);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(930, 107);
            this.dataGridView1.TabIndex = 35;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(478, 247);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPassword.TabIndex = 34;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(438, 250);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(37, 13);
            this.lblClave.TabIndex = 33;
            this.lblClave.Text = "Clave:";
            this.lblClave.UseMnemonic = false;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(283, 247);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.txtBoxEmail.TabIndex = 32;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(216, 251);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 31;
            this.lblEmail.Text = "Email:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(388, 154);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Administración de usuarios";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(131, 108);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(47, 13);
            this.lblNombreCliente.TabIndex = 27;
            this.lblNombreCliente.Text = "Nombre:";
            this.lblNombreCliente.Click += new System.EventHandler(this.lblNombreCliente_Click);
            // 
            // txtBoxDNI
            // 
            this.txtBoxDNI.Location = new System.Drawing.Point(510, 104);
            this.txtBoxDNI.Name = "txtBoxDNI";
            this.txtBoxDNI.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDNI.TabIndex = 26;
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(359, 104);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(100, 20);
            this.txtBox.TabIndex = 25;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(187, 104);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCliente.TabIndex = 24;
            // 
            // lbldni
            // 
            this.lbldni.AutoSize = true;
            this.lbldni.Location = new System.Drawing.Point(475, 107);
            this.lbldni.Name = "lbldni";
            this.lbldni.Size = new System.Drawing.Size(29, 13);
            this.lbldni.TabIndex = 23;
            this.lbldni.Text = "DNI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nacimiento:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(306, 108);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 21;
            this.lblApellido.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(631, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Cargo:";
            // 
            // lblDatosPersonales
            // 
            this.lblDatosPersonales.AutoSize = true;
            this.lblDatosPersonales.Location = new System.Drawing.Point(137, 65);
            this.lblDatosPersonales.Name = "lblDatosPersonales";
            this.lblDatosPersonales.Size = new System.Drawing.Size(90, 13);
            this.lblDatosPersonales.TabIndex = 41;
            this.lblDatosPersonales.Text = "Datos Personales";
            // 
            // lblDatosLaborales
            // 
            this.lblDatosLaborales.AutoSize = true;
            this.lblDatosLaborales.Location = new System.Drawing.Point(137, 206);
            this.lblDatosLaborales.Name = "lblDatosLaborales";
            this.lblDatosLaborales.Size = new System.Drawing.Size(84, 13);
            this.lblDatosLaborales.TabIndex = 42;
            this.lblDatosLaborales.Text = "Datos Laborales";
            // 
            // lblCuil
            // 
            this.lblCuil.AutoSize = true;
            this.lblCuil.Location = new System.Drawing.Point(630, 107);
            this.lblCuil.Name = "lblCuil";
            this.lblCuil.Size = new System.Drawing.Size(34, 13);
            this.lblCuil.TabIndex = 43;
            this.lblCuil.Text = "CUIL:";
            // 
            // txtBoxCuil
            // 
            this.txtBoxCuil.Location = new System.Drawing.Point(670, 104);
            this.txtBoxCuil.Name = "txtBoxCuil";
            this.txtBoxCuil.Size = new System.Drawing.Size(123, 20);
            this.txtBoxCuil.TabIndex = 44;
            // 
            // comBoxCargo
            // 
            this.comBoxCargo.FormattingEnabled = true;
            this.comBoxCargo.Location = new System.Drawing.Point(672, 244);
            this.comBoxCargo.Name = "comBoxCargo";
            this.comBoxCargo.Size = new System.Drawing.Size(121, 21);
            this.comBoxCargo.TabIndex = 45;
            // 
            // ColNombreCliente
            // 
            this.ColNombreCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColNombreCliente.HeaderText = "Nombre";
            this.ColNombreCliente.MinimumWidth = 8;
            this.ColNombreCliente.Name = "ColNombreCliente";
            this.ColNombreCliente.Width = 69;
            // 
            // ColCuil
            // 
            this.ColCuil.HeaderText = "CUIL";
            this.ColCuil.Name = "ColCuil";
            // 
            // ColCargo
            // 
            this.ColCargo.HeaderText = "Cargo";
            this.ColCargo.Name = "ColCargo";
            // 
            // ColApellidoCliente
            // 
            this.ColApellidoCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColApellidoCliente.HeaderText = "Apellido";
            this.ColApellidoCliente.MinimumWidth = 8;
            this.ColApellidoCliente.Name = "ColApellidoCliente";
            this.ColApellidoCliente.Width = 69;
            // 
            // ColFechaNac
            // 
            this.ColFechaNac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColFechaNac.HeaderText = "Fecha de nacimiento";
            this.ColFechaNac.MinimumWidth = 8;
            this.ColFechaNac.Name = "ColFechaNac";
            this.ColFechaNac.Width = 120;
            // 
            // ColDNICliente
            // 
            this.ColDNICliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColDNICliente.HeaderText = "DNI";
            this.ColDNICliente.MinimumWidth = 8;
            this.ColDNICliente.Name = "ColDNICliente";
            this.ColDNICliente.Width = 51;
            // 
            // ColEmail
            // 
            this.ColEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColEmail.HeaderText = "Email";
            this.ColEmail.MinimumWidth = 8;
            this.ColEmail.Name = "ColEmail";
            this.ColEmail.Width = 57;
            // 
            // ColPasswordCliente
            // 
            this.ColPasswordCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColPasswordCliente.HeaderText = "Clave";
            this.ColPasswordCliente.MinimumWidth = 8;
            this.ColPasswordCliente.Name = "ColPasswordCliente";
            this.ColPasswordCliente.Width = 59;
            // 
            // ColSeleccionarCliente
            // 
            this.ColSeleccionarCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColSeleccionarCliente.HeaderText = "Seleccionar";
            this.ColSeleccionarCliente.MinimumWidth = 8;
            this.ColSeleccionarCliente.Name = "ColSeleccionarCliente";
            this.ColSeleccionarCliente.Width = 69;
            // 
            // testABMEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 550);
            this.Controls.Add(this.comBoxCargo);
            this.Controls.Add(this.txtBoxCuil);
            this.Controls.Add(this.lblCuil);
            this.Controls.Add(this.lblDatosLaborales);
            this.Controls.Add(this.lblDatosPersonales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.btnGuardarCliente);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.txtBoxDNI);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.lbldni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblApellido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "testABMEmpleados";
            this.Text = "testAmbEmpleados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnGuardarCliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtBoxDNI;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lbldni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDatosPersonales;
        private System.Windows.Forms.Label lblDatosLaborales;
        private System.Windows.Forms.Label lblCuil;
        private System.Windows.Forms.TextBox txtBoxCuil;
        private System.Windows.Forms.ComboBox comBoxCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCuil;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColApellidoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDNICliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPasswordCliente;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColSeleccionarCliente;
    }
}