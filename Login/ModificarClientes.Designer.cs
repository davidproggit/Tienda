
namespace Login
{
    partial class ModificarClientes
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
            this.lblListaClientes = new System.Windows.Forms.Label();
            this.DGVClientes = new System.Windows.Forms.DataGridView();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSeleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListaClientes
            // 
            this.lblListaClientes.AutoSize = true;
            this.lblListaClientes.Location = new System.Drawing.Point(394, 50);
            this.lblListaClientes.Name = "lblListaClientes";
            this.lblListaClientes.Size = new System.Drawing.Size(102, 16);
            this.lblListaClientes.TabIndex = 0;
            this.lblListaClientes.Text = "Lista de Clientes";
            this.lblListaClientes.Click += new System.EventHandler(this.lblTituloCliente);
            // 
            // DGVClientes
            // 
            this.DGVClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNombre,
            this.ColApellido,
            this.ColDNI,
            this.ColEmail,
            this.ColPassword,
            this.ColSeleccion});
            this.DGVClientes.Location = new System.Drawing.Point(77, 158);
            this.DGVClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGVClientes.Name = "DGVClientes";
            this.DGVClientes.Size = new System.Drawing.Size(750, 116);
            this.DGVClientes.TabIndex = 1;
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Location = new System.Drawing.Point(789, 474);
            this.btnEliminarCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(110, 36);
            this.btnEliminarCliente.TabIndex = 2;
            this.btnEliminarCliente.Text = "Eliminar Cliente";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.Location = new System.Drawing.Point(636, 480);
            this.btnModificarCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(110, 24);
            this.btnModificarCliente.TabIndex = 3;
            this.btnModificarCliente.Text = "Modificar Cliente";
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            // 
            // ColNombre
            // 
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.Name = "ColNombre";
            // 
            // ColApellido
            // 
            this.ColApellido.HeaderText = "Apellido";
            this.ColApellido.Name = "ColApellido";
            // 
            // ColDNI
            // 
            this.ColDNI.HeaderText = "DNI";
            this.ColDNI.Name = "ColDNI";
            // 
            // ColEmail
            // 
            this.ColEmail.HeaderText = "Email";
            this.ColEmail.Name = "ColEmail";
            // 
            // ColPassword
            // 
            this.ColPassword.HeaderText = "Password";
            this.ColPassword.Name = "ColPassword";
            // 
            // ColSeleccion
            // 
            this.ColSeleccion.HeaderText = "Seleccion";
            this.ColSeleccion.Name = "ColSeleccion";
            // 
            // ModificarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.btnModificarCliente);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.DGVClientes);
            this.Controls.Add(this.lblListaClientes);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ModificarClientes";
            this.Text = "ABMClientes";
            ((System.ComponentModel.ISupportInitialize)(this.DGVClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListaClientes;
        private System.Windows.Forms.DataGridView DGVClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPassword;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColSeleccion;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnModificarCliente;
    }
}