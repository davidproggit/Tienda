namespace WindowsFormsApp2
{
    partial class Interfaz
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
            this.Imagen = new System.Windows.Forms.PictureBox();
            this.NombreCategoria = new System.Windows.Forms.Label();
            this.Pestanas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Resultados = new System.Windows.Forms.Label();
            this.BarraNavegacion = new System.Windows.Forms.MenuStrip();
            this.mueblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puertasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sillasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).BeginInit();
            this.Pestanas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.BarraNavegacion.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Imagen
            // 
            this.Imagen.Location = new System.Drawing.Point(35, 194);
            this.Imagen.Name = "Imagen";
            this.Imagen.Size = new System.Drawing.Size(324, 241);
            this.Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagen.TabIndex = 1;
            this.Imagen.TabStop = false;
            // 
            // NombreCategoria
            // 
            this.NombreCategoria.AutoSize = true;
            this.NombreCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreCategoria.Location = new System.Drawing.Point(28, 86);
            this.NombreCategoria.Name = "NombreCategoria";
            this.NombreCategoria.Size = new System.Drawing.Size(351, 37);
            this.NombreCategoria.TabIndex = 3;
            this.NombreCategoria.Text = "Nombre de la categoria";
            // 
            // Pestanas
            // 
            this.Pestanas.Controls.Add(this.tabPage1);
            this.Pestanas.Controls.Add(this.tabPage2);
            this.Pestanas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pestanas.Location = new System.Drawing.Point(1, 0);
            this.Pestanas.Name = "Pestanas";
            this.Pestanas.SelectedIndex = 0;
            this.Pestanas.Size = new System.Drawing.Size(1144, 481);
            this.Pestanas.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Resultados);
            this.tabPage1.Controls.Add(this.Imagen);
            this.tabPage1.Controls.Add(this.NombreCategoria);
            this.tabPage1.Controls.Add(this.BarraNavegacion);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 46);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1136, 431);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tienda";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // Resultados
            // 
            this.Resultados.AutoSize = true;
            this.Resultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultados.Location = new System.Drawing.Point(30, 133);
            this.Resultados.Name = "Resultados";
            this.Resultados.Size = new System.Drawing.Size(134, 29);
            this.Resultados.TabIndex = 6;
            this.Resultados.Text = "Resultados";
            // 
            // BarraNavegacion
            // 
            this.BarraNavegacion.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.BarraNavegacion.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.BarraNavegacion.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.BarraNavegacion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mueblesToolStripMenuItem});
            this.BarraNavegacion.Location = new System.Drawing.Point(3, 3);
            this.BarraNavegacion.Name = "BarraNavegacion";
            this.BarraNavegacion.Size = new System.Drawing.Size(1130, 44);
            this.BarraNavegacion.TabIndex = 4;
            this.BarraNavegacion.Text = "menuStrip2";
            // 
            // mueblesToolStripMenuItem
            // 
            this.mueblesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.puertasToolStripMenuItem,
            this.mesasToolStripMenuItem,
            this.sillasToolStripMenuItem});
            this.mueblesToolStripMenuItem.Name = "mueblesToolStripMenuItem";
            this.mueblesToolStripMenuItem.Size = new System.Drawing.Size(129, 40);
            this.mueblesToolStripMenuItem.Text = "Muebles";
            // 
            // puertasToolStripMenuItem
            // 
            this.puertasToolStripMenuItem.Name = "puertasToolStripMenuItem";
            this.puertasToolStripMenuItem.Size = new System.Drawing.Size(206, 44);
            this.puertasToolStripMenuItem.Text = "Puertas";
            this.puertasToolStripMenuItem.Click += new System.EventHandler(this.puertasToolStripMenuItem_Click);
            // 
            // mesasToolStripMenuItem
            // 
            this.mesasToolStripMenuItem.Name = "mesasToolStripMenuItem";
            this.mesasToolStripMenuItem.Size = new System.Drawing.Size(206, 44);
            this.mesasToolStripMenuItem.Text = "Mesas";
            this.mesasToolStripMenuItem.Click += new System.EventHandler(this.mesasToolStripMenuItem_Click);
            // 
            // sillasToolStripMenuItem
            // 
            this.sillasToolStripMenuItem.Name = "sillasToolStripMenuItem";
            this.sillasToolStripMenuItem.Size = new System.Drawing.Size(206, 44);
            this.sillasToolStripMenuItem.Text = "Sillas";
            this.sillasToolStripMenuItem.Click += new System.EventHandler(this.sillasToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 46);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1136, 431);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Perfil";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(521, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "David";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.usuario;
            this.pictureBox1.Location = new System.Drawing.Point(429, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 268);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Interfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 527);
            this.Controls.Add(this.Pestanas);
            this.Name = "Interfaz";
            this.Text = "Interfaz";
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).EndInit();
            this.Pestanas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.BarraNavegacion.ResumeLayout(false);
            this.BarraNavegacion.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Imagen;
        private System.Windows.Forms.Label NombreCategoria;
        private System.Windows.Forms.TabControl Pestanas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip BarraNavegacion;
        private System.Windows.Forms.ToolStripMenuItem mueblesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puertasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sillasToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Resultados;
    }
}