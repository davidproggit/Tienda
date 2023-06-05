namespace CapaDePresentacion.PantallasUsuarios.Gerente
{
    partial class PantallaReporte
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
            this.grillaOrdenes = new System.Windows.Forms.DataGridView();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            this.btnUltimaSemana = new System.Windows.Forms.Button();
            this.btnUltimoMes = new System.Windows.Forms.Button();
            this.comboVendedores = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grillaOrdenes)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaOrdenes
            // 
            this.grillaOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaOrdenes.Location = new System.Drawing.Point(54, 141);
            this.grillaOrdenes.Name = "grillaOrdenes";
            this.grillaOrdenes.RowHeadersWidth = 62;
            this.grillaOrdenes.RowTemplate.Height = 28;
            this.grillaOrdenes.Size = new System.Drawing.Size(1147, 494);
            this.grillaOrdenes.TabIndex = 0;
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTodo.Location = new System.Drawing.Point(54, 36);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(185, 74);
            this.btnMostrarTodo.TabIndex = 1;
            this.btnMostrarTodo.Text = "Mostrar todo";
            this.btnMostrarTodo.UseVisualStyleBackColor = true;
            this.btnMostrarTodo.Click += new System.EventHandler(this.btnMostrarTodo_Click);
            // 
            // btnUltimaSemana
            // 
            this.btnUltimaSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimaSemana.Location = new System.Drawing.Point(274, 36);
            this.btnUltimaSemana.Name = "btnUltimaSemana";
            this.btnUltimaSemana.Size = new System.Drawing.Size(221, 74);
            this.btnUltimaSemana.TabIndex = 2;
            this.btnUltimaSemana.Text = "Ultima semana";
            this.btnUltimaSemana.UseVisualStyleBackColor = true;
            this.btnUltimaSemana.Click += new System.EventHandler(this.btnUltimaSemana_Click);
            // 
            // btnUltimoMes
            // 
            this.btnUltimoMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoMes.Location = new System.Drawing.Point(530, 36);
            this.btnUltimoMes.Name = "btnUltimoMes";
            this.btnUltimoMes.Size = new System.Drawing.Size(204, 74);
            this.btnUltimoMes.TabIndex = 3;
            this.btnUltimoMes.Text = "Ultimo mes";
            this.btnUltimoMes.UseVisualStyleBackColor = true;
            this.btnUltimoMes.Click += new System.EventHandler(this.btnUltimoMes_Click);
            // 
            // comboVendedores
            // 
            this.comboVendedores.FormattingEnabled = true;
            this.comboVendedores.Location = new System.Drawing.Point(811, 64);
            this.comboVendedores.Name = "comboVendedores";
            this.comboVendedores.Size = new System.Drawing.Size(121, 28);
            this.comboVendedores.TabIndex = 4;
            // 
            // PantallaReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 741);
            this.Controls.Add(this.comboVendedores);
            this.Controls.Add(this.btnUltimoMes);
            this.Controls.Add(this.btnUltimaSemana);
            this.Controls.Add(this.btnMostrarTodo);
            this.Controls.Add(this.grillaOrdenes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaReporte";
            this.Text = "PantallaReporte";
            this.Load += new System.EventHandler(this.PantallaReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaOrdenes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaOrdenes;
        private System.Windows.Forms.Button btnMostrarTodo;
        private System.Windows.Forms.Button btnUltimaSemana;
        private System.Windows.Forms.Button btnUltimoMes;
        private System.Windows.Forms.ComboBox comboVendedores;
    }
}