namespace WindowsFormsApp1
{
    partial class ProductosVista
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
            this.contenedorProductos = new System.Windows.Forms.FlowLayoutPanel();
            this.linkCarrito = new System.Windows.Forms.LinkLabel();
            this.linkHistorial = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // contenedorProductos
            // 
            this.contenedorProductos.AutoScroll = true;
            this.contenedorProductos.BackColor = System.Drawing.Color.Gray;
            this.contenedorProductos.Location = new System.Drawing.Point(44, 266);
            this.contenedorProductos.Name = "contenedorProductos";
            this.contenedorProductos.Size = new System.Drawing.Size(1270, 344);
            this.contenedorProductos.TabIndex = 0;
            // 
            // linkCarrito
            // 
            this.linkCarrito.AutoSize = true;
            this.linkCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkCarrito.Location = new System.Drawing.Point(1200, 26);
            this.linkCarrito.Name = "linkCarrito";
            this.linkCarrito.Size = new System.Drawing.Size(114, 37);
            this.linkCarrito.TabIndex = 1;
            this.linkCarrito.TabStop = true;
            this.linkCarrito.Text = "Carrito";
            this.linkCarrito.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCarrito_LinkClicked);
            // 
            // linkHistorial
            // 
            this.linkHistorial.AutoSize = true;
            this.linkHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkHistorial.Location = new System.Drawing.Point(832, 26);
            this.linkHistorial.Name = "linkHistorial";
            this.linkHistorial.Size = new System.Drawing.Size(310, 37);
            this.linkHistorial.TabIndex = 2;
            this.linkHistorial.TabStop = true;
            this.linkHistorial.Text = "Historial de compras";
            this.linkHistorial.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHistorial_LinkClicked);
            // 
            // ProductosVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 660);
            this.Controls.Add(this.linkHistorial);
            this.Controls.Add(this.linkCarrito);
            this.Controls.Add(this.contenedorProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductosVista";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ProductosVista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel contenedorProductos;
        private System.Windows.Forms.LinkLabel linkCarrito;
        private System.Windows.Forms.LinkLabel linkHistorial;
    }
}

