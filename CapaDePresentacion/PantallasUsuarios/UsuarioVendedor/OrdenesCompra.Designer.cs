﻿namespace CapaDePresentacion.PantallasUsuarios.Vendedor
{
    partial class OrdenesCompra
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
            this.contenedorProductos.Location = new System.Drawing.Point(90, 15);
            this.contenedorProductos.Name = "contenedorProductos";
            this.contenedorProductos.Size = new System.Drawing.Size(620, 420);
            this.contenedorProductos.TabIndex = 3;
            // 
            // OrdenesCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contenedorProductos);
            this.Name = "OrdenesCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrdenesCompra";
            this.Load += new System.EventHandler(this.OrdenesCompra_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel contenedorProductos;
    }
}