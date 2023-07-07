namespace CapaDePresentacion.PantallasUsuarios.UsuarioCliente
{
    partial class OrdenCompraVendedor
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblOrden = new System.Windows.Forms.Label();
            this.btnAprobar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.linkDetalle = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblOrden
            // 
            this.lblOrden.AutoSize = true;
            this.lblOrden.BackColor = System.Drawing.Color.Transparent;
            this.lblOrden.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrden.ForeColor = System.Drawing.Color.Black;
            this.lblOrden.Location = new System.Drawing.Point(46, 26);
            this.lblOrden.Name = "lblOrden";
            this.lblOrden.Size = new System.Drawing.Size(103, 36);
            this.lblOrden.TabIndex = 8;
            this.lblOrden.Text = "Orden";
            // 
            // btnAprobar
            // 
            this.btnAprobar.BackColor = System.Drawing.Color.LightGreen;
            this.btnAprobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAprobar.Location = new System.Drawing.Point(720, 80);
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Size = new System.Drawing.Size(235, 59);
            this.btnAprobar.TabIndex = 11;
            this.btnAprobar.Text = "Aprobar compra";
            this.btnAprobar.UseVisualStyleBackColor = false;
            this.btnAprobar.Click += new System.EventHandler(this.btnAprobar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(453, 80);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(235, 59);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar compra";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(46, 103);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(112, 36);
            this.lblEstado.TabIndex = 20;
            this.lblEstado.Text = "Estado";
            // 
            // linkDetalle
            // 
            this.linkDetalle.AutoSize = true;
            this.linkDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkDetalle.Location = new System.Drawing.Point(264, 92);
            this.linkDetalle.Name = "linkDetalle";
            this.linkDetalle.Size = new System.Drawing.Size(151, 32);
            this.linkDetalle.TabIndex = 21;
            this.linkDetalle.TabStop = true;
            this.linkDetalle.Text = "Ver detalle";
            this.linkDetalle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDetalle_LinkClicked);
            // 
            // OrdenCompraVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.linkDetalle);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAprobar);
            this.Controls.Add(this.lblOrden);
            this.Name = "OrdenCompraVendedor";
            this.Size = new System.Drawing.Size(989, 161);
            this.Load += new System.EventHandler(this.OrdenCompraVendedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblOrden;
        private System.Windows.Forms.Button btnAprobar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.LinkLabel linkDetalle;
    }
}
