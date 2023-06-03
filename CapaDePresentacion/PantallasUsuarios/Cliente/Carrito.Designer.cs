namespace CapaDePresentacion.PantallasUsuarios.Cliente
{
    partial class Carrito
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
            this.linkEnviarCompra = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // contenedorProductos
            // 
            this.contenedorProductos.AutoScroll = true;
            this.contenedorProductos.BackColor = System.Drawing.Color.Gray;
            this.contenedorProductos.Location = new System.Drawing.Point(122, 56);
            this.contenedorProductos.Name = "contenedorProductos";
            this.contenedorProductos.Size = new System.Drawing.Size(620, 420);
            this.contenedorProductos.TabIndex = 1;
            // 
            // linkEnviarCompra
            // 
            this.linkEnviarCompra.AutoSize = true;
            this.linkEnviarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkEnviarCompra.Location = new System.Drawing.Point(645, 498);
            this.linkEnviarCompra.Name = "linkEnviarCompra";
            this.linkEnviarCompra.Size = new System.Drawing.Size(224, 37);
            this.linkEnviarCompra.TabIndex = 2;
            this.linkEnviarCompra.TabStop = true;
            this.linkEnviarCompra.Text = "Enviar compra";
            this.linkEnviarCompra.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEnviarCompra_LinkClicked);
            // 
            // Carrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 558);
            this.Controls.Add(this.linkEnviarCompra);
            this.Controls.Add(this.contenedorProductos);
            this.Name = "Carrito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carrito";
            this.Load += new System.EventHandler(this.Carrito_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel contenedorProductos;
        private System.Windows.Forms.LinkLabel linkEnviarCompra;
    }
}