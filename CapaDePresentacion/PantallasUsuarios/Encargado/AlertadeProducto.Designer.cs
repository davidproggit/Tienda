
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCantidadProducto = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtCantidadMinima = new System.Windows.Forms.TextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.grillaProductos = new System.Windows.Forms.DataGridView();
            this.btnGuardarAlerta = new System.Windows.Forms.Button();
            this.btnCancelarAlerta = new System.Windows.Forms.Button();
            this.panelAlerta = new System.Windows.Forms.Panel();
            this.panelAccion = new System.Windows.Forms.Panel();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSeleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rTBoxMensajeAlerta = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProductos)).BeginInit();
            this.panelAlerta.SuspendLayout();
            this.panelAccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(332, 38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(148, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Alerta de productos";
            // 
            // lblCantidadProducto
            // 
            this.lblCantidadProducto.AutoSize = true;
            this.lblCantidadProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadProducto.Location = new System.Drawing.Point(9, 18);
            this.lblCantidadProducto.Name = "lblCantidadProducto";
            this.lblCantidadProducto.Size = new System.Drawing.Size(174, 20);
            this.lblCantidadProducto.TabIndex = 1;
            this.lblCantidadProducto.Text = "Cantidad de productos:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(75, 89);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(703, 20);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "En esta pantalla se configurara el alerta dependiendo la cantidad de productos qu" +
    "e esten en stock";
            // 
            // txtCantidadMinima
            // 
            this.txtCantidadMinima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadMinima.Location = new System.Drawing.Point(185, 18);
            this.txtCantidadMinima.Name = "txtCantidadMinima";
            this.txtCantidadMinima.Size = new System.Drawing.Size(68, 26);
            this.txtCantidadMinima.TabIndex = 3;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(322, 18);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(73, 20);
            this.lblMensaje.TabIndex = 4;
            this.lblMensaje.Text = "Mensaje:";
            // 
            // grillaProductos
            // 
            this.grillaProductos.AllowUserToAddRows = false;
            this.grillaProductos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grillaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColNombre,
            this.ColCantidad,
            this.ColSeleccionar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grillaProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.grillaProductos.Location = new System.Drawing.Point(139, 134);
            this.grillaProductos.Name = "grillaProductos";
            this.grillaProductos.ReadOnly = true;
            this.grillaProductos.RowHeadersWidth = 62;
            this.grillaProductos.Size = new System.Drawing.Size(485, 162);
            this.grillaProductos.TabIndex = 6;
            // 
            // btnGuardarAlerta
            // 
            this.btnGuardarAlerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarAlerta.Location = new System.Drawing.Point(121, 12);
            this.btnGuardarAlerta.Name = "btnGuardarAlerta";
            this.btnGuardarAlerta.Size = new System.Drawing.Size(81, 33);
            this.btnGuardarAlerta.TabIndex = 7;
            this.btnGuardarAlerta.Text = "Guardar";
            this.btnGuardarAlerta.UseVisualStyleBackColor = true;
            this.btnGuardarAlerta.Click += new System.EventHandler(this.btnGuardarAlerta_Click);
            // 
            // btnCancelarAlerta
            // 
            this.btnCancelarAlerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarAlerta.Location = new System.Drawing.Point(7, 12);
            this.btnCancelarAlerta.Name = "btnCancelarAlerta";
            this.btnCancelarAlerta.Size = new System.Drawing.Size(89, 33);
            this.btnCancelarAlerta.TabIndex = 8;
            this.btnCancelarAlerta.Text = "Cancelar";
            this.btnCancelarAlerta.UseVisualStyleBackColor = true;
            this.btnCancelarAlerta.Click += new System.EventHandler(this.btnAlertCancelar_Click);
            // 
            // panelAlerta
            // 
            this.panelAlerta.BackColor = System.Drawing.Color.LightGray;
            this.panelAlerta.Controls.Add(this.rTBoxMensajeAlerta);
            this.panelAlerta.Controls.Add(this.lblCantidadProducto);
            this.panelAlerta.Controls.Add(this.txtCantidadMinima);
            this.panelAlerta.Controls.Add(this.lblMensaje);
            this.panelAlerta.Location = new System.Drawing.Point(85, 317);
            this.panelAlerta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelAlerta.Name = "panelAlerta";
            this.panelAlerta.Size = new System.Drawing.Size(606, 170);
            this.panelAlerta.TabIndex = 9;
            // 
            // panelAccion
            // 
            this.panelAccion.BackColor = System.Drawing.Color.LightGray;
            this.panelAccion.Controls.Add(this.btnCancelarAlerta);
            this.panelAccion.Controls.Add(this.btnGuardarAlerta);
            this.panelAccion.Location = new System.Drawing.Point(567, 550);
            this.panelAccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelAccion.Name = "panelAccion";
            this.panelAccion.Size = new System.Drawing.Size(211, 55);
            this.panelAccion.TabIndex = 10;
            // 
            // ColID
            // 
            this.ColID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColID.HeaderText = "ID";
            this.ColID.MinimumWidth = 8;
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Width = 51;
            // 
            // ColNombre
            // 
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.MinimumWidth = 8;
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            this.ColNombre.Width = 150;
            // 
            // ColCantidad
            // 
            this.ColCantidad.HeaderText = "Cantidad";
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.ReadOnly = true;
            // 
            // ColSeleccionar
            // 
            this.ColSeleccionar.HeaderText = "Seleccionar";
            this.ColSeleccionar.Name = "ColSeleccionar";
            this.ColSeleccionar.ReadOnly = true;
            this.ColSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColSeleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // rTBoxMensajeAlerta
            // 
            this.rTBoxMensajeAlerta.Location = new System.Drawing.Point(406, 18);
            this.rTBoxMensajeAlerta.Name = "rTBoxMensajeAlerta";
            this.rTBoxMensajeAlerta.Size = new System.Drawing.Size(100, 96);
            this.rTBoxMensajeAlerta.TabIndex = 5;
            this.rTBoxMensajeAlerta.Text = "";
            // 
            // AlertadeProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 634);
            this.Controls.Add(this.panelAccion);
            this.Controls.Add(this.panelAlerta);
            this.Controls.Add(this.grillaProductos);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblTitulo);
            this.Name = "AlertadeProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alerta de Producto";
            this.Load += new System.EventHandler(this.AlertadeProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaProductos)).EndInit();
            this.panelAlerta.ResumeLayout(false);
            this.panelAlerta.PerformLayout();
            this.panelAccion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCantidadProducto;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtCantidadMinima;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.DataGridView grillaProductos;
        private System.Windows.Forms.Button btnGuardarAlerta;
        private System.Windows.Forms.Button btnCancelarAlerta;
        private System.Windows.Forms.Panel panelAlerta;
        private System.Windows.Forms.Panel panelAccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColSeleccionar;
        private System.Windows.Forms.RichTextBox rTBoxMensajeAlerta;
    }
}