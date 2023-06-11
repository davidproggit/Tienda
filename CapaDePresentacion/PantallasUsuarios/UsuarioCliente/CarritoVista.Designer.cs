namespace CapaDePresentacion.PantallasUsuarios.UsuarioCliente
{
    partial class CarritoVista
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
            this.btnEnviarCompra = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contenedorProductos
            // 
            this.contenedorProductos.AutoScroll = true;
            this.contenedorProductos.BackColor = System.Drawing.Color.Gray;
            this.contenedorProductos.Location = new System.Drawing.Point(122, 56);
            this.contenedorProductos.Name = "contenedorProductos";
            this.contenedorProductos.Size = new System.Drawing.Size(598, 420);
            this.contenedorProductos.TabIndex = 1;
            // 
            // btnEnviarCompra
            // 
            this.btnEnviarCompra.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEnviarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarCompra.Location = new System.Drawing.Point(461, 520);
            this.btnEnviarCompra.Name = "btnEnviarCompra";
            this.btnEnviarCompra.Size = new System.Drawing.Size(259, 71);
            this.btnEnviarCompra.TabIndex = 4;
            this.btnEnviarCompra.Text = "Enviar productos";
            this.btnEnviarCompra.UseVisualStyleBackColor = false;
            this.btnEnviarCompra.Click += new System.EventHandler(this.btnEnviarCompra_Click);
            // 
            // btnVaciar
            // 
            this.btnVaciar.BackColor = System.Drawing.Color.Red;
            this.btnVaciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaciar.Location = new System.Drawing.Point(122, 520);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(207, 71);
            this.btnVaciar.TabIndex = 5;
            this.btnVaciar.Text = "Vaciar carrito";
            this.btnVaciar.UseVisualStyleBackColor = false;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // CarritoVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 613);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.btnEnviarCompra);
            this.Controls.Add(this.contenedorProductos);
            this.Name = "CarritoVista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carrito";
            this.Load += new System.EventHandler(this.Carrito_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel contenedorProductos;
        private System.Windows.Forms.Button btnEnviarCompra;
        private System.Windows.Forms.Button btnVaciar;
    }
}