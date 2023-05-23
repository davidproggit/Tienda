
namespace CapaDePresentacion
{
    partial class AlertadeProducto
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
            this.lblGenerarAlerta = new System.Windows.Forms.Label();
            this.lblcantidadproducto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidadMinima = new System.Windows.Forms.TextBox();
            this.lblMen = new System.Windows.Forms.Label();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.grilla = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardarAlerta = new System.Windows.Forms.Button();
            this.btnAlertCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGenerarAlerta
            // 
            this.lblGenerarAlerta.AutoSize = true;
            this.lblGenerarAlerta.Location = new System.Drawing.Point(498, 58);
            this.lblGenerarAlerta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenerarAlerta.Name = "lblGenerarAlerta";
            this.lblGenerarAlerta.Size = new System.Drawing.Size(148, 20);
            this.lblGenerarAlerta.TabIndex = 0;
            this.lblGenerarAlerta.Text = "Alerta de productos";
            // 
            // lblcantidadproducto
            // 
            this.lblcantidadproducto.AutoSize = true;
            this.lblcantidadproducto.Location = new System.Drawing.Point(66, 455);
            this.lblcantidadproducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcantidadproducto.Name = "lblcantidadproducto";
            this.lblcantidadproducto.Size = new System.Drawing.Size(174, 20);
            this.lblcantidadproducto.TabIndex = 1;
            this.lblcantidadproducto.Text = "Cantidad de productos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(703, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "En esta pantalla se configurara el alerta dependiendo la cantidad de productos qu" +
    "e esten en stock";
            // 
            // txtCantidadMinima
            // 
            this.txtCantidadMinima.Location = new System.Drawing.Point(250, 451);
            this.txtCantidadMinima.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCantidadMinima.Name = "txtCantidadMinima";
            this.txtCantidadMinima.Size = new System.Drawing.Size(212, 26);
            this.txtCantidadMinima.TabIndex = 3;
            // 
            // lblMen
            // 
            this.lblMen.AutoSize = true;
            this.lblMen.Location = new System.Drawing.Point(166, 511);
            this.lblMen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMen.Name = "lblMen";
            this.lblMen.Size = new System.Drawing.Size(73, 20);
            this.lblMen.TabIndex = 4;
            this.lblMen.Text = "Mensaje:";
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(250, 506);
            this.txtMensaje.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(212, 26);
            this.txtMensaje.TabIndex = 5;
            // 
            // grilla
            // 
            this.grilla.AllowUserToAddRows = false;
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColNombre});
            this.grilla.Location = new System.Drawing.Point(194, 237);
            this.grilla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grilla.Name = "grilla";
            this.grilla.RowHeadersWidth = 62;
            this.grilla.Size = new System.Drawing.Size(383, 161);
            this.grilla.TabIndex = 6;
            // 
            // ColID
            // 
            this.ColID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColID.HeaderText = "ID";
            this.ColID.MinimumWidth = 8;
            this.ColID.Name = "ColID";
            this.ColID.Width = 62;
            // 
            // ColNombre
            // 
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.MinimumWidth = 8;
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.Width = 150;
            // 
            // btnGuardarAlerta
            // 
            this.btnGuardarAlerta.Location = new System.Drawing.Point(1016, 614);
            this.btnGuardarAlerta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarAlerta.Name = "btnGuardarAlerta";
            this.btnGuardarAlerta.Size = new System.Drawing.Size(112, 35);
            this.btnGuardarAlerta.TabIndex = 7;
            this.btnGuardarAlerta.Text = "Guardar";
            this.btnGuardarAlerta.UseVisualStyleBackColor = true;
            this.btnGuardarAlerta.Click += new System.EventHandler(this.btnGuardarAlerta_Click);
            // 
            // btnAlertCancelar
            // 
            this.btnAlertCancelar.Location = new System.Drawing.Point(870, 614);
            this.btnAlertCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAlertCancelar.Name = "btnAlertCancelar";
            this.btnAlertCancelar.Size = new System.Drawing.Size(112, 35);
            this.btnAlertCancelar.TabIndex = 8;
            this.btnAlertCancelar.Text = "Cancelar";
            this.btnAlertCancelar.UseVisualStyleBackColor = true;
            this.btnAlertCancelar.Click += new System.EventHandler(this.btnAlertCancelar_Click);
            // 
            // AlertadeProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnAlertCancelar);
            this.Controls.Add(this.btnGuardarAlerta);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.lblMen);
            this.Controls.Add(this.txtCantidadMinima);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcantidadproducto);
            this.Controls.Add(this.lblGenerarAlerta);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AlertadeProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alerta de Producto";
            this.Load += new System.EventHandler(this.AlertadeProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGenerarAlerta;
        private System.Windows.Forms.Label lblcantidadproducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidadMinima;
        private System.Windows.Forms.Label lblMen;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.Button btnGuardarAlerta;
        private System.Windows.Forms.Button btnAlertCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
    }
}