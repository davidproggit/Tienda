﻿namespace CapaDePresentacion.PantallasUsuarios.UsuarioGerente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grillaOrdenes = new System.Windows.Forms.DataGridView();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            this.btnUltimaSemana = new System.Windows.Forms.Button();
            this.btnUltimoMes = new System.Windows.Forms.Button();
            this.comboVendedores = new System.Windows.Forms.ComboBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaOrdenes)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaOrdenes
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaOrdenes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grillaOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grillaOrdenes.DefaultCellStyle = dataGridViewCellStyle4;
            this.grillaOrdenes.EnableHeadersVisualStyles = false;
            this.grillaOrdenes.Location = new System.Drawing.Point(54, 141);
            this.grillaOrdenes.Name = "grillaOrdenes";
            this.grillaOrdenes.RowHeadersWidth = 62;
            this.grillaOrdenes.RowTemplate.Height = 28;
            this.grillaOrdenes.Size = new System.Drawing.Size(1147, 494);
            this.grillaOrdenes.TabIndex = 0;
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMostrarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTodo.Location = new System.Drawing.Point(54, 36);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(185, 74);
            this.btnMostrarTodo.TabIndex = 1;
            this.btnMostrarTodo.Text = "Mostrar todo";
            this.btnMostrarTodo.UseVisualStyleBackColor = false;
            this.btnMostrarTodo.Click += new System.EventHandler(this.btnMostrarTodo_Click);
            // 
            // btnUltimaSemana
            // 
            this.btnUltimaSemana.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUltimaSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimaSemana.Location = new System.Drawing.Point(274, 36);
            this.btnUltimaSemana.Name = "btnUltimaSemana";
            this.btnUltimaSemana.Size = new System.Drawing.Size(221, 74);
            this.btnUltimaSemana.TabIndex = 2;
            this.btnUltimaSemana.Text = "Ultima semana";
            this.btnUltimaSemana.UseVisualStyleBackColor = false;
            this.btnUltimaSemana.Click += new System.EventHandler(this.btnUltimaSemana_Click);
            // 
            // btnUltimoMes
            // 
            this.btnUltimoMes.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUltimoMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoMes.Location = new System.Drawing.Point(530, 36);
            this.btnUltimoMes.Name = "btnUltimoMes";
            this.btnUltimoMes.Size = new System.Drawing.Size(204, 74);
            this.btnUltimoMes.TabIndex = 3;
            this.btnUltimoMes.Text = "Ultimo mes";
            this.btnUltimoMes.UseVisualStyleBackColor = false;
            this.btnUltimoMes.Click += new System.EventHandler(this.btnUltimoMes_Click);
            // 
            // comboVendedores
            // 
            this.comboVendedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboVendedores.FormattingEnabled = true;
            this.comboVendedores.Location = new System.Drawing.Point(979, 51);
            this.comboVendedores.Name = "comboVendedores";
            this.comboVendedores.Size = new System.Drawing.Size(185, 45);
            this.comboVendedores.TabIndex = 4;
            this.comboVendedores.SelectedIndexChanged += new System.EventHandler(this.comboVendedores_SelectedIndexChanged);
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.Location = new System.Drawing.Point(789, 51);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(174, 37);
            this.lblVendedor.TabIndex = 6;
            this.lblVendedor.Text = "Vendedor: ";
            // 
            // PantallaReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1409, 741);
            this.Controls.Add(this.lblVendedor);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaOrdenes;
        private System.Windows.Forms.Button btnMostrarTodo;
        private System.Windows.Forms.Button btnUltimaSemana;
        private System.Windows.Forms.Button btnUltimoMes;
        private System.Windows.Forms.ComboBox comboVendedores;
        private System.Windows.Forms.Label lblVendedor;
    }
}