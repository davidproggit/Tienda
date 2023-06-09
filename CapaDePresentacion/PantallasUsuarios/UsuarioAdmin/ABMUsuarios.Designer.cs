﻿namespace CapaDePresentacion
{
    partial class ABMUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.btnGuardarUsuario = new System.Windows.Forms.Button();
            this.grillaUsuarios = new System.Windows.Forms.DataGridView();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblDatosPersonales = new System.Windows.Forms.Label();
            this.lblDatosLaborales = new System.Windows.Forms.Label();
            this.lblCuil = new System.Windows.Forms.Label();
            this.txtCuil = new System.Windows.Forms.TextBox();
            this.comboCargo = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.panelDatosPersonales = new System.Windows.Forms.Panel();
            this.panelDatosLaborales = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaUsuarios)).BeginInit();
            this.panelDatosPersonales.SuspendLayout();
            this.panelDatosLaborales.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.Location = new System.Drawing.Point(1153, 475);
            this.btnEliminarUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(126, 55);
            this.btnEliminarUsuario.TabIndex = 38;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarUsuario.Location = new System.Drawing.Point(307, 27);
            this.btnBuscarUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(126, 55);
            this.btnBuscarUsuario.TabIndex = 36;
            this.btnBuscarUsuario.Text = "Buscar";
            this.btnBuscarUsuario.UseVisualStyleBackColor = true;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // btnGuardarUsuario
            // 
            this.btnGuardarUsuario.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarUsuario.Location = new System.Drawing.Point(845, 475);
            this.btnGuardarUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarUsuario.Name = "btnGuardarUsuario";
            this.btnGuardarUsuario.Size = new System.Drawing.Size(120, 55);
            this.btnGuardarUsuario.TabIndex = 37;
            this.btnGuardarUsuario.Text = "Guardar";
            this.btnGuardarUsuario.UseVisualStyleBackColor = false;
            this.btnGuardarUsuario.Click += new System.EventHandler(this.btnGuardarUsuario_Click);
            // 
            // grillaUsuarios
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grillaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grillaUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.grillaUsuarios.EnableHeadersVisualStyles = false;
            this.grillaUsuarios.Location = new System.Drawing.Point(64, 600);
            this.grillaUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grillaUsuarios.Name = "grillaUsuarios";
            this.grillaUsuarios.RowHeadersWidth = 62;
            this.grillaUsuarios.Size = new System.Drawing.Size(1322, 201);
            this.grillaUsuarios.TabIndex = 35;
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(684, 73);
            this.txtClave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(148, 32);
            this.txtClave.TabIndex = 34;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(596, 76);
            this.lblClave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(80, 29);
            this.lblClave.TabIndex = 33;
            this.lblClave.Text = "Clave:";
            this.lblClave.UseMnemonic = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(422, 73);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(148, 32);
            this.txtEmail.TabIndex = 32;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(334, 74);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(80, 29);
            this.lblEmail.TabIndex = 31;
            this.lblEmail.Text = "Email:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(663, 34);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(302, 29);
            this.lblTitulo.TabIndex = 28;
            this.lblTitulo.Text = "Administración de usuarios";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(21, 83);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(107, 29);
            this.lblNombre.TabIndex = 27;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtDNI
            // 
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(684, 84);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(148, 32);
            this.txtDNI.TabIndex = 26;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(422, 84);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(148, 32);
            this.txtApellido.TabIndex = 25;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(142, 83);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(148, 32);
            this.txtNombre.TabIndex = 24;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(616, 84);
            this.lblDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(60, 29);
            this.lblDni.TabIndex = 23;
            this.lblDni.Text = "DNI:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(306, 84);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(108, 29);
            this.lblApellido.TabIndex = 21;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(853, 74);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(85, 29);
            this.lblCargo.TabIndex = 40;
            this.lblCargo.Text = "Cargo:";
            // 
            // lblDatosPersonales
            // 
            this.lblDatosPersonales.AutoSize = true;
            this.lblDatosPersonales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosPersonales.Location = new System.Drawing.Point(16, 13);
            this.lblDatosPersonales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatosPersonales.Name = "lblDatosPersonales";
            this.lblDatosPersonales.Size = new System.Drawing.Size(203, 29);
            this.lblDatosPersonales.TabIndex = 41;
            this.lblDatosPersonales.Text = "Datos Personales";
            // 
            // lblDatosLaborales
            // 
            this.lblDatosLaborales.AutoSize = true;
            this.lblDatosLaborales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosLaborales.Location = new System.Drawing.Point(16, 19);
            this.lblDatosLaborales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatosLaborales.Name = "lblDatosLaborales";
            this.lblDatosLaborales.Size = new System.Drawing.Size(188, 29);
            this.lblDatosLaborales.TabIndex = 42;
            this.lblDatosLaborales.Text = "Datos Laborales";
            // 
            // lblCuil
            // 
            this.lblCuil.AutoSize = true;
            this.lblCuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuil.Location = new System.Drawing.Point(866, 83);
            this.lblCuil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCuil.Name = "lblCuil";
            this.lblCuil.Size = new System.Drawing.Size(72, 29);
            this.lblCuil.TabIndex = 43;
            this.lblCuil.Text = "CUIL:";
            // 
            // txtCuil
            // 
            this.txtCuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuil.Location = new System.Drawing.Point(957, 84);
            this.txtCuil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCuil.Name = "txtCuil";
            this.txtCuil.Size = new System.Drawing.Size(182, 32);
            this.txtCuil.TabIndex = 44;
            // 
            // comboCargo
            // 
            this.comboCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCargo.FormattingEnabled = true;
            this.comboCargo.Location = new System.Drawing.Point(959, 71);
            this.comboCargo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboCargo.Name = "comboCargo";
            this.comboCargo.Size = new System.Drawing.Size(180, 34);
            this.comboCargo.TabIndex = 45;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(21, 72);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(102, 29);
            this.lblUsuario.TabIndex = 47;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(142, 74);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(148, 32);
            this.txtUsuario.TabIndex = 46;
            // 
            // panelDatosPersonales
            // 
            this.panelDatosPersonales.BackColor = System.Drawing.Color.Aquamarine;
            this.panelDatosPersonales.Controls.Add(this.lblDatosPersonales);
            this.panelDatosPersonales.Controls.Add(this.lblApellido);
            this.panelDatosPersonales.Controls.Add(this.lblDni);
            this.panelDatosPersonales.Controls.Add(this.txtNombre);
            this.panelDatosPersonales.Controls.Add(this.txtCuil);
            this.panelDatosPersonales.Controls.Add(this.txtApellido);
            this.panelDatosPersonales.Controls.Add(this.lblCuil);
            this.panelDatosPersonales.Controls.Add(this.txtDNI);
            this.panelDatosPersonales.Controls.Add(this.lblNombre);
            this.panelDatosPersonales.Location = new System.Drawing.Point(64, 115);
            this.panelDatosPersonales.Name = "panelDatosPersonales";
            this.panelDatosPersonales.Size = new System.Drawing.Size(1159, 134);
            this.panelDatosPersonales.TabIndex = 48;
            // 
            // panelDatosLaborales
            // 
            this.panelDatosLaborales.BackColor = System.Drawing.Color.Aquamarine;
            this.panelDatosLaborales.Controls.Add(this.lblDatosLaborales);
            this.panelDatosLaborales.Controls.Add(this.lblEmail);
            this.panelDatosLaborales.Controls.Add(this.lblUsuario);
            this.panelDatosLaborales.Controls.Add(this.txtEmail);
            this.panelDatosLaborales.Controls.Add(this.txtUsuario);
            this.panelDatosLaborales.Controls.Add(this.lblClave);
            this.panelDatosLaborales.Controls.Add(this.comboCargo);
            this.panelDatosLaborales.Controls.Add(this.txtClave);
            this.panelDatosLaborales.Controls.Add(this.lblCargo);
            this.panelDatosLaborales.Location = new System.Drawing.Point(64, 301);
            this.panelDatosLaborales.Name = "panelDatosLaborales";
            this.panelDatosLaborales.Size = new System.Drawing.Size(1159, 126);
            this.panelDatosLaborales.TabIndex = 49;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(104, 40);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(172, 32);
            this.txtBuscar.TabIndex = 48;
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrar.Location = new System.Drawing.Point(8, 40);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(81, 29);
            this.lblFiltrar.TabIndex = 50;
            this.lblFiltrar.Text = "Filtrar:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.lblFiltrar);
            this.panel1.Controls.Add(this.btnBuscarUsuario);
            this.panel1.Location = new System.Drawing.Point(64, 458);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 100);
            this.panel1.TabIndex = 51;
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarUsuario.Location = new System.Drawing.Point(1000, 475);
            this.btnEditarUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(120, 55);
            this.btnEditarUsuario.TabIndex = 52;
            this.btnEditarUsuario.Text = "Editar";
            this.btnEditarUsuario.UseVisualStyleBackColor = false;
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click);
            // 
            // ABMUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1551, 846);
            this.Controls.Add(this.btnEditarUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGuardarUsuario);
            this.Controls.Add(this.panelDatosLaborales);
            this.Controls.Add(this.panelDatosPersonales);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.grillaUsuarios);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ABMUsuarios";
            this.Text = "testAmbEmpleados";
            this.Load += new System.EventHandler(this.ABMUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaUsuarios)).EndInit();
            this.panelDatosPersonales.ResumeLayout(false);
            this.panelDatosPersonales.PerformLayout();
            this.panelDatosLaborales.ResumeLayout(false);
            this.panelDatosLaborales.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.Button btnGuardarUsuario;
        private System.Windows.Forms.DataGridView grillaUsuarios;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblDatosPersonales;
        private System.Windows.Forms.Label lblDatosLaborales;
        private System.Windows.Forms.Label lblCuil;
        private System.Windows.Forms.TextBox txtCuil;
        private System.Windows.Forms.ComboBox comboCargo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Panel panelDatosPersonales;
        private System.Windows.Forms.Panel panelDatosLaborales;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEditarUsuario;
    }
}