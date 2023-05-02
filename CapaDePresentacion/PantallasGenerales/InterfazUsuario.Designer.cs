namespace CapaDePresentacion.PantallasGenerales
{
    partial class InterfazUsuario
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
            this.panelFormulario = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.IconoPerfil = new System.Windows.Forms.PictureBox();
            this.linkCerrarSesion = new System.Windows.Forms.LinkLabel();
            this.linkPerfil = new System.Windows.Forms.LinkLabel();
            this.etiquetaNombre = new System.Windows.Forms.Label();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.Tienda = new System.Windows.Forms.Label();
            this.panelContenedor.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconoPerfil)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFormulario
            // 
            this.panelFormulario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormulario.Location = new System.Drawing.Point(200, 51);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(1047, 623);
            this.panelFormulario.TabIndex = 2;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContenedor.Controls.Add(this.panelFormulario);
            this.panelContenedor.Controls.Add(this.panelMenu);
            this.panelContenedor.Controls.Add(this.panelBarraTitulo);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.MinimumSize = new System.Drawing.Size(650, 650);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1247, 674);
            this.panelContenedor.TabIndex = 1;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Black;
            this.panelMenu.Controls.Add(this.IconoPerfil);
            this.panelMenu.Controls.Add(this.linkCerrarSesion);
            this.panelMenu.Controls.Add(this.linkPerfil);
            this.panelMenu.Controls.Add(this.etiquetaNombre);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 51);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 623);
            this.panelMenu.TabIndex = 1;
            // 
            // IconoPerfil
            // 
            this.IconoPerfil.Image = global::CapaDePresentacion.Properties.Resources.IconoUsuario;
            this.IconoPerfil.Location = new System.Drawing.Point(52, 31);
            this.IconoPerfil.Name = "IconoPerfil";
            this.IconoPerfil.Size = new System.Drawing.Size(90, 90);
            this.IconoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconoPerfil.TabIndex = 0;
            this.IconoPerfil.TabStop = false;
            // 
            // linkCerrarSesion
            // 
            this.linkCerrarSesion.AutoSize = true;
            this.linkCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkCerrarSesion.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.linkCerrarSesion.Location = new System.Drawing.Point(12, 483);
            this.linkCerrarSesion.Name = "linkCerrarSesion";
            this.linkCerrarSesion.Size = new System.Drawing.Size(168, 30);
            this.linkCerrarSesion.TabIndex = 5;
            this.linkCerrarSesion.TabStop = true;
            this.linkCerrarSesion.Text = "Cerrar sesion";
            this.linkCerrarSesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCerrarSesion_LinkClicked);
            // 
            // linkPerfil
            // 
            this.linkPerfil.AutoSize = true;
            this.linkPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkPerfil.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.linkPerfil.Location = new System.Drawing.Point(12, 181);
            this.linkPerfil.Name = "linkPerfil";
            this.linkPerfil.Size = new System.Drawing.Size(104, 30);
            this.linkPerfil.TabIndex = 0;
            this.linkPerfil.TabStop = true;
            this.linkPerfil.Text = "Mi perfil";
            this.linkPerfil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPerfil_LinkClicked);
            // 
            // etiquetaNombre
            // 
            this.etiquetaNombre.AutoSize = true;
            this.etiquetaNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.etiquetaNombre.Location = new System.Drawing.Point(59, 139);
            this.etiquetaNombre.Name = "etiquetaNombre";
            this.etiquetaNombre.Size = new System.Drawing.Size(94, 27);
            this.etiquetaNombre.TabIndex = 1;
            this.etiquetaNombre.Text = "Usuario";
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.Black;
            this.panelBarraTitulo.Controls.Add(this.Tienda);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(1247, 51);
            this.panelBarraTitulo.TabIndex = 0;
            // 
            // Tienda
            // 
            this.Tienda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tienda.AutoSize = true;
            this.Tienda.BackColor = System.Drawing.Color.Black;
            this.Tienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tienda.ForeColor = System.Drawing.Color.White;
            this.Tienda.Location = new System.Drawing.Point(554, 11);
            this.Tienda.Name = "Tienda";
            this.Tienda.Size = new System.Drawing.Size(115, 37);
            this.Tienda.TabIndex = 3;
            this.Tienda.Text = "Tienda";
            // 
            // InterfazUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 674);
            this.Controls.Add(this.panelContenedor);
            this.Name = "InterfazUsuario";
            this.Text = "InterfazUsuario";
            this.Load += new System.EventHandler(this.InterfazUsuario_Load);
            this.panelContenedor.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconoPerfil)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox IconoPerfil;
        private System.Windows.Forms.LinkLabel linkCerrarSesion;
        private System.Windows.Forms.LinkLabel linkPerfil;
        private System.Windows.Forms.Label etiquetaNombre;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Label Tienda;
    }
}