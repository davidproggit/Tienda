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
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.btnGuardarUsuario = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColSeleccionarCliente = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDatosPersonales = new System.Windows.Forms.Label();
            this.lblDatosLaborales = new System.Windows.Forms.Label();
            this.lblCuil = new System.Windows.Forms.Label();
            this.txtCuil = new System.Windows.Forms.TextBox();
            this.comboCargo = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Location = new System.Drawing.Point(1300, 760);
            this.btnEliminarUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(112, 35);
            this.btnEliminarUsuario.TabIndex = 38;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Location = new System.Drawing.Point(1300, 466);
            this.btnBuscarUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(112, 35);
            this.btnBuscarUsuario.TabIndex = 36;
            this.btnBuscarUsuario.Text = "Buscar";
            this.btnBuscarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnGuardarUsuario
            // 
            this.btnGuardarUsuario.Location = new System.Drawing.Point(1150, 466);
            this.btnGuardarUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarUsuario.Name = "btnGuardarUsuario";
            this.btnGuardarUsuario.Size = new System.Drawing.Size(105, 35);
            this.btnGuardarUsuario.TabIndex = 37;
            this.btnGuardarUsuario.Text = "Guardar";
            this.btnGuardarUsuario.UseVisualStyleBackColor = true;
            this.btnGuardarUsuario.Click += new System.EventHandler(this.btnGuardarUsuario_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSeleccionarCliente});
            this.dataGridView1.Location = new System.Drawing.Point(164, 566);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1395, 165);
            this.dataGridView1.TabIndex = 35;
            // 
            // ColSeleccionarCliente
            // 
            this.ColSeleccionarCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColSeleccionarCliente.HeaderText = "Seleccionar";
            this.ColSeleccionarCliente.MinimumWidth = 8;
            this.ColSeleccionarCliente.Name = "ColSeleccionarCliente";
            this.ColSeleccionarCliente.Width = 98;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(765, 375);
            this.txtClave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(148, 26);
            this.txtClave.TabIndex = 34;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(712, 382);
            this.lblClave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(52, 20);
            this.lblClave.TabIndex = 33;
            this.lblClave.Text = "Clave:";
            this.lblClave.UseMnemonic = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(538, 379);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(148, 26);
            this.txtEmail.TabIndex = 32;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(459, 379);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 31;
            this.lblEmail.Text = "Email:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(663, 34);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(199, 20);
            this.lblTitulo.TabIndex = 28;
            this.lblTitulo.Text = "Administración de usuarios";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(196, 166);
            this.lblNombreCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(69, 20);
            this.lblNombreCliente.TabIndex = 27;
            this.lblNombreCliente.Text = "Nombre:";
            this.lblNombreCliente.Click += new System.EventHandler(this.lblNombreCliente_Click);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(765, 160);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(148, 26);
            this.txtDNI.TabIndex = 26;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(538, 160);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(148, 26);
            this.txtApellido.TabIndex = 25;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(280, 160);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(148, 26);
            this.txtNombre.TabIndex = 24;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(712, 165);
            this.lblDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(41, 20);
            this.lblDni.TabIndex = 23;
            this.lblDni.Text = "DNI:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(459, 166);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(69, 20);
            this.lblApellido.TabIndex = 21;
            this.lblApellido.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(945, 377);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Cargo:";
            // 
            // lblDatosPersonales
            // 
            this.lblDatosPersonales.AutoSize = true;
            this.lblDatosPersonales.Location = new System.Drawing.Point(206, 100);
            this.lblDatosPersonales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatosPersonales.Name = "lblDatosPersonales";
            this.lblDatosPersonales.Size = new System.Drawing.Size(135, 20);
            this.lblDatosPersonales.TabIndex = 41;
            this.lblDatosPersonales.Text = "Datos Personales";
            // 
            // lblDatosLaborales
            // 
            this.lblDatosLaborales.AutoSize = true;
            this.lblDatosLaborales.Location = new System.Drawing.Point(196, 319);
            this.lblDatosLaborales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatosLaborales.Name = "lblDatosLaborales";
            this.lblDatosLaborales.Size = new System.Drawing.Size(126, 20);
            this.lblDatosLaborales.TabIndex = 42;
            this.lblDatosLaborales.Text = "Datos Laborales";
            // 
            // lblCuil
            // 
            this.lblCuil.AutoSize = true;
            this.lblCuil.Location = new System.Drawing.Point(945, 165);
            this.lblCuil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCuil.Name = "lblCuil";
            this.lblCuil.Size = new System.Drawing.Size(50, 20);
            this.lblCuil.TabIndex = 43;
            this.lblCuil.Text = "CUIL:";
            // 
            // txtCuil
            // 
            this.txtCuil.Location = new System.Drawing.Point(1005, 160);
            this.txtCuil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCuil.Name = "txtCuil";
            this.txtCuil.Size = new System.Drawing.Size(182, 26);
            this.txtCuil.TabIndex = 44;
            // 
            // comboCargo
            // 
            this.comboCargo.FormattingEnabled = true;
            this.comboCargo.Location = new System.Drawing.Point(1005, 373);
            this.comboCargo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboCargo.Name = "comboCargo";
            this.comboCargo.Size = new System.Drawing.Size(180, 28);
            this.comboCargo.TabIndex = 45;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(197, 376);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(68, 20);
            this.lblUsuario.TabIndex = 47;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(280, 377);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(148, 26);
            this.txtUsuario.TabIndex = 46;
            // 
            // testABMEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1551, 846);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.comboCargo);
            this.Controls.Add(this.txtCuil);
            this.Controls.Add(this.lblCuil);
            this.Controls.Add(this.lblDatosLaborales);
            this.Controls.Add(this.lblDatosPersonales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnBuscarUsuario);
            this.Controls.Add(this.btnGuardarUsuario);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblApellido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "testABMEmpleados";
            this.Text = "testAmbEmpleados";
            this.Load += new System.EventHandler(this.testABMEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.Button btnGuardarUsuario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDatosPersonales;
        private System.Windows.Forms.Label lblDatosLaborales;
        private System.Windows.Forms.Label lblCuil;
        private System.Windows.Forms.TextBox txtCuil;
        private System.Windows.Forms.ComboBox comboCargo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColSeleccionarCliente;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
    }
}