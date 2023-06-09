namespace CapaDePresentacion.PantallasUsuarios.UsuarioVendedor
{
    partial class OrdenesCompraClientes
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
            this.contenedorProductos = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // contenedorProductos
            // 
            this.contenedorProductos.AutoScroll = true;
            this.contenedorProductos.BackColor = System.Drawing.Color.Gray;
            this.contenedorProductos.Location = new System.Drawing.Point(30, 12);
            this.contenedorProductos.Name = "contenedorProductos";
            this.contenedorProductos.Size = new System.Drawing.Size(1050, 568);
            this.contenedorProductos.TabIndex = 3;
            // 
            // OrdenesCompraClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 621);
            this.Controls.Add(this.contenedorProductos);
            this.Name = "OrdenesCompraClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrdenesCompra";
            this.Load += new System.EventHandler(this.OrdenesCompra_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel contenedorProductos;
    }
}