namespace Login
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.botonAcceder = new System.Windows.Forms.Button();
            this.etiquetaError = new System.Windows.Forms.Label();
            this.botonMinimizar = new System.Windows.Forms.PictureBox();
            this.botonCerrar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Nirmala UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(283, 114);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(423, 42);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tienda UPE";
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Nirmala UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(283, 204);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(423, 42);
            this.txtClave.TabIndex = 2;
            this.txtClave.Text = "Clave";
            this.txtClave.Enter += new System.EventHandler(this.txtClave_Enter);
            this.txtClave.Leave += new System.EventHandler(this.txtClave_Leave);
            // 
            // botonAcceder
            // 
            this.botonAcceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAcceder.Location = new System.Drawing.Point(283, 339);
            this.botonAcceder.Name = "botonAcceder";
            this.botonAcceder.Size = new System.Drawing.Size(423, 57);
            this.botonAcceder.TabIndex = 3;
            this.botonAcceder.Text = "Acceder";
            this.botonAcceder.UseVisualStyleBackColor = true;
            this.botonAcceder.Click += new System.EventHandler(this.botonAcceder_Click);
            // 
            // etiquetaError
            // 
            this.etiquetaError.AutoSize = true;
            this.etiquetaError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaError.ForeColor = System.Drawing.Color.Red;
            this.etiquetaError.Location = new System.Drawing.Point(278, 281);
            this.etiquetaError.Name = "etiquetaError";
            this.etiquetaError.Size = new System.Drawing.Size(54, 25);
            this.etiquetaError.TabIndex = 5;
            this.etiquetaError.Text = "Error";
            this.etiquetaError.Visible = false;
            // 
            // botonMinimizar
            // 
            this.botonMinimizar.Image = global::Login.Properties.Resources.BotonMinimizar;
            this.botonMinimizar.Location = new System.Drawing.Point(736, 0);
            this.botonMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.botonMinimizar.Name = "botonMinimizar";
            this.botonMinimizar.Size = new System.Drawing.Size(32, 32);
            this.botonMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.botonMinimizar.TabIndex = 7;
            this.botonMinimizar.TabStop = false;
            this.botonMinimizar.Click += new System.EventHandler(this.botonMinimizar_Click);
            // 
            // botonCerrar
            // 
            this.botonCerrar.Image = global::Login.Properties.Resources.BotonCerrar;
            this.botonCerrar.Location = new System.Drawing.Point(768, 0);
            this.botonCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(32, 32);
            this.botonCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.botonCerrar.TabIndex = 6;
            this.botonCerrar.TabStop = false;
            this.botonCerrar.Click += new System.EventHandler(this.botonCerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonMinimizar);
            this.Controls.Add(this.botonCerrar);
            this.Controls.Add(this.etiquetaError);
            this.Controls.Add(this.botonAcceder);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button botonAcceder;
        private System.Windows.Forms.Label etiquetaError;
        private System.Windows.Forms.PictureBox botonMinimizar;
        private System.Windows.Forms.PictureBox botonCerrar;
        private System.Windows.Forms.Label label2;
    }
}

