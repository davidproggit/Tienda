namespace CapaDePresentacion.PantallasUsuarios.Cliente
{
    partial class ClienteCarrito
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
            System.Windows.Forms.Label lblDireccion;
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grillaProductos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxNumeroTarjeta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumTarjeta = new System.Windows.Forms.Label();
            this.tBoxTarjeta = new System.Windows.Forms.TextBox();
            this.lblCodTarjeta = new System.Windows.Forms.Label();
            this.tBoxCodTarjeta = new System.Windows.Forms.TextBox();
            this.lblCodPostal = new System.Windows.Forms.Label();
            this.txtBoxCodPostal = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.tBoxCalle = new System.Windows.Forms.TextBox();
            this.lblPisoDepto = new System.Windows.Forms.Label();
            this.ttBoxPisoDepto = new System.Windows.Forms.TextBox();
            this.lblAlturaCalle = new System.Windows.Forms.Label();
            this.tBoxAlturaCalle = new System.Windows.Forms.TextBox();
            this.tBoxAltura = new System.Windows.Forms.TextBox();
            this.rButtonTarjeta = new System.Windows.Forms.RadioButton();
            this.rButtonEfectivo = new System.Windows.Forms.RadioButton();
            this.btnEnviarCompra = new System.Windows.Forms.Button();
            this.btnAnularCompra = new System.Windows.Forms.Button();
            this.btnQuitarProducto = new System.Windows.Forms.Button();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSeleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblTotalCompra = new System.Windows.Forms.Label();
            this.tBoxTotalCompra = new System.Windows.Forms.TextBox();
            lblDireccion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(356, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(56, 20);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Carrito";
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
            this.Precio,
            this.Cantidad,
            this.ColSeleccionar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grillaProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.grillaProductos.Location = new System.Drawing.Point(67, 56);
            this.grillaProductos.Name = "grillaProductos";
            this.grillaProductos.ReadOnly = true;
            this.grillaProductos.RowHeadersWidth = 62;
            this.grillaProductos.Size = new System.Drawing.Size(667, 198);
            this.grillaProductos.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Localidad:";
            // 
            // tBoxNumeroTarjeta
            // 
            this.tBoxNumeroTarjeta.Location = new System.Drawing.Point(294, 422);
            this.tBoxNumeroTarjeta.Name = "tBoxNumeroTarjeta";
            this.tBoxNumeroTarjeta.Size = new System.Drawing.Size(100, 20);
            this.tBoxNumeroTarjeta.TabIndex = 11;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new System.Drawing.Point(38, 383);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new System.Drawing.Size(109, 13);
            lblDireccion.TabIndex = 12;
            lblDireccion.Text = "Dirección de entrega:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 558);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Medio de pago:";
            // 
            // lblNumTarjeta
            // 
            this.lblNumTarjeta.AutoSize = true;
            this.lblNumTarjeta.Location = new System.Drawing.Point(37, 644);
            this.lblNumTarjeta.Name = "lblNumTarjeta";
            this.lblNumTarjeta.Size = new System.Drawing.Size(94, 13);
            this.lblNumTarjeta.TabIndex = 14;
            this.lblNumTarjeta.Text = "Número de tarjeta:";
            // 
            // tBoxTarjeta
            // 
            this.tBoxTarjeta.Location = new System.Drawing.Point(134, 641);
            this.tBoxTarjeta.Name = "tBoxTarjeta";
            this.tBoxTarjeta.Size = new System.Drawing.Size(100, 20);
            this.tBoxTarjeta.TabIndex = 15;
            // 
            // lblCodTarjeta
            // 
            this.lblCodTarjeta.AutoSize = true;
            this.lblCodTarjeta.Location = new System.Drawing.Point(260, 644);
            this.lblCodTarjeta.Name = "lblCodTarjeta";
            this.lblCodTarjeta.Size = new System.Drawing.Size(79, 13);
            this.lblCodTarjeta.TabIndex = 16;
            this.lblCodTarjeta.Text = "Código Tarjeta:";
            // 
            // tBoxCodTarjeta
            // 
            this.tBoxCodTarjeta.Location = new System.Drawing.Point(345, 641);
            this.tBoxCodTarjeta.Name = "tBoxCodTarjeta";
            this.tBoxCodTarjeta.Size = new System.Drawing.Size(100, 20);
            this.tBoxCodTarjeta.TabIndex = 17;
            // 
            // lblCodPostal
            // 
            this.lblCodPostal.AutoSize = true;
            this.lblCodPostal.Location = new System.Drawing.Point(17, 425);
            this.lblCodPostal.Name = "lblCodPostal";
            this.lblCodPostal.Size = new System.Drawing.Size(75, 13);
            this.lblCodPostal.TabIndex = 18;
            this.lblCodPostal.Text = "Codigo Postal:";
            // 
            // txtBoxCodPostal
            // 
            this.txtBoxCodPostal.Location = new System.Drawing.Point(98, 422);
            this.txtBoxCodPostal.Name = "txtBoxCodPostal";
            this.txtBoxCodPostal.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCodPostal.TabIndex = 19;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(427, 425);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(33, 13);
            this.lblCalle.TabIndex = 20;
            this.lblCalle.Text = "Calle:";
            // 
            // tBoxCalle
            // 
            this.tBoxCalle.Location = new System.Drawing.Point(466, 422);
            this.tBoxCalle.Name = "tBoxCalle";
            this.tBoxCalle.Size = new System.Drawing.Size(100, 20);
            this.tBoxCalle.TabIndex = 21;
            // 
            // lblPisoDepto
            // 
            this.lblPisoDepto.AutoSize = true;
            this.lblPisoDepto.Location = new System.Drawing.Point(603, 424);
            this.lblPisoDepto.Name = "lblPisoDepto";
            this.lblPisoDepto.Size = new System.Drawing.Size(64, 13);
            this.lblPisoDepto.TabIndex = 22;
            this.lblPisoDepto.Text = "Piso/Depto:";
            // 
            // ttBoxPisoDepto
            // 
            this.ttBoxPisoDepto.Location = new System.Drawing.Point(673, 421);
            this.ttBoxPisoDepto.Name = "ttBoxPisoDepto";
            this.ttBoxPisoDepto.Size = new System.Drawing.Size(100, 20);
            this.ttBoxPisoDepto.TabIndex = 23;
            // 
            // lblAlturaCalle
            // 
            this.lblAlturaCalle.AutoSize = true;
            this.lblAlturaCalle.Location = new System.Drawing.Point(55, 472);
            this.lblAlturaCalle.Name = "lblAlturaCalle";
            this.lblAlturaCalle.Size = new System.Drawing.Size(37, 13);
            this.lblAlturaCalle.TabIndex = 24;
            this.lblAlturaCalle.Text = "Altura:";
            // 
            // tBoxAlturaCalle
            // 
            this.tBoxAlturaCalle.Dock = System.Windows.Forms.DockStyle.Top;
            this.tBoxAlturaCalle.Location = new System.Drawing.Point(0, 0);
            this.tBoxAlturaCalle.Name = "tBoxAlturaCalle";
            this.tBoxAlturaCalle.Size = new System.Drawing.Size(801, 20);
            this.tBoxAlturaCalle.TabIndex = 25;
            // 
            // tBoxAltura
            // 
            this.tBoxAltura.Location = new System.Drawing.Point(98, 469);
            this.tBoxAltura.Name = "tBoxAltura";
            this.tBoxAltura.Size = new System.Drawing.Size(100, 20);
            this.tBoxAltura.TabIndex = 26;
            // 
            // rButtonTarjeta
            // 
            this.rButtonTarjeta.AutoSize = true;
            this.rButtonTarjeta.Location = new System.Drawing.Point(40, 599);
            this.rButtonTarjeta.Name = "rButtonTarjeta";
            this.rButtonTarjeta.Size = new System.Drawing.Size(58, 17);
            this.rButtonTarjeta.TabIndex = 28;
            this.rButtonTarjeta.TabStop = true;
            this.rButtonTarjeta.Text = "Tarjeta";
            this.rButtonTarjeta.UseVisualStyleBackColor = true;
            // 
            // rButtonEfectivo
            // 
            this.rButtonEfectivo.AutoSize = true;
            this.rButtonEfectivo.Location = new System.Drawing.Point(113, 599);
            this.rButtonEfectivo.Name = "rButtonEfectivo";
            this.rButtonEfectivo.Size = new System.Drawing.Size(64, 17);
            this.rButtonEfectivo.TabIndex = 29;
            this.rButtonEfectivo.TabStop = true;
            this.rButtonEfectivo.Text = "Efectivo";
            this.rButtonEfectivo.UseVisualStyleBackColor = true;
            // 
            // btnEnviarCompra
            // 
            this.btnEnviarCompra.Location = new System.Drawing.Point(649, 703);
            this.btnEnviarCompra.Name = "btnEnviarCompra";
            this.btnEnviarCompra.Size = new System.Drawing.Size(85, 33);
            this.btnEnviarCompra.TabIndex = 30;
            this.btnEnviarCompra.Text = "Enviar compra";
            this.btnEnviarCompra.UseVisualStyleBackColor = true;
            // 
            // btnAnularCompra
            // 
            this.btnAnularCompra.Location = new System.Drawing.Point(531, 703);
            this.btnAnularCompra.Name = "btnAnularCompra";
            this.btnAnularCompra.Size = new System.Drawing.Size(95, 33);
            this.btnAnularCompra.TabIndex = 31;
            this.btnAnularCompra.Text = "Anular Compra";
            this.btnAnularCompra.UseVisualStyleBackColor = true;
            // 
            // btnQuitarProducto
            // 
            this.btnQuitarProducto.Location = new System.Drawing.Point(649, 322);
            this.btnQuitarProducto.Name = "btnQuitarProducto";
            this.btnQuitarProducto.Size = new System.Drawing.Size(85, 44);
            this.btnQuitarProducto.TabIndex = 32;
            this.btnQuitarProducto.Text = "Quitar Producto";
            this.btnQuitarProducto.UseVisualStyleBackColor = true;
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
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 8;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 150;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 8;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 150;
            // 
            // ColSeleccionar
            // 
            this.ColSeleccionar.HeaderText = "Seleccionar";
            this.ColSeleccionar.Name = "ColSeleccionar";
            this.ColSeleccionar.ReadOnly = true;
            // 
            // lblTotalCompra
            // 
            this.lblTotalCompra.AutoSize = true;
            this.lblTotalCompra.Location = new System.Drawing.Point(26, 286);
            this.lblTotalCompra.Name = "lblTotalCompra";
            this.lblTotalCompra.Size = new System.Drawing.Size(88, 13);
            this.lblTotalCompra.TabIndex = 33;
            this.lblTotalCompra.Text = "Total de Compra:";
            // 
            // tBoxTotalCompra
            // 
            this.tBoxTotalCompra.Location = new System.Drawing.Point(113, 283);
            this.tBoxTotalCompra.Name = "tBoxTotalCompra";
            this.tBoxTotalCompra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tBoxTotalCompra.Size = new System.Drawing.Size(114, 20);
            this.tBoxTotalCompra.TabIndex = 34;
            // 
            // ClienteCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 753);
            this.Controls.Add(this.tBoxTotalCompra);
            this.Controls.Add(this.lblTotalCompra);
            this.Controls.Add(this.btnQuitarProducto);
            this.Controls.Add(this.btnAnularCompra);
            this.Controls.Add(this.btnEnviarCompra);
            this.Controls.Add(this.rButtonEfectivo);
            this.Controls.Add(this.rButtonTarjeta);
            this.Controls.Add(this.tBoxAltura);
            this.Controls.Add(this.tBoxAlturaCalle);
            this.Controls.Add(this.lblAlturaCalle);
            this.Controls.Add(this.ttBoxPisoDepto);
            this.Controls.Add(this.lblPisoDepto);
            this.Controls.Add(this.tBoxCalle);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.txtBoxCodPostal);
            this.Controls.Add(this.lblCodPostal);
            this.Controls.Add(this.tBoxCodTarjeta);
            this.Controls.Add(this.lblCodTarjeta);
            this.Controls.Add(this.tBoxTarjeta);
            this.Controls.Add(this.lblNumTarjeta);
            this.Controls.Add(this.label2);
            this.Controls.Add(lblDireccion);
            this.Controls.Add(this.tBoxNumeroTarjeta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grillaProductos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ClienteCarrito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClienteCarrito";
            this.Load += new System.EventHandler(this.ClienteCarrito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView grillaProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColSeleccionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxNumeroTarjeta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumTarjeta;
        private System.Windows.Forms.TextBox tBoxTarjeta;
        private System.Windows.Forms.Label lblCodTarjeta;
        private System.Windows.Forms.TextBox tBoxCodTarjeta;
        private System.Windows.Forms.Label lblCodPostal;
        private System.Windows.Forms.TextBox txtBoxCodPostal;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.TextBox tBoxCalle;
        private System.Windows.Forms.Label lblPisoDepto;
        private System.Windows.Forms.TextBox ttBoxPisoDepto;
        private System.Windows.Forms.Label lblAlturaCalle;
        private System.Windows.Forms.TextBox tBoxAlturaCalle;
        private System.Windows.Forms.TextBox tBoxAltura;
        private System.Windows.Forms.RadioButton rButtonTarjeta;
        private System.Windows.Forms.RadioButton rButtonEfectivo;
        private System.Windows.Forms.Button btnEnviarCompra;
        private System.Windows.Forms.Button btnAnularCompra;
        private System.Windows.Forms.Button btnQuitarProducto;
        private System.Windows.Forms.Label lblTotalCompra;
        private System.Windows.Forms.TextBox tBoxTotalCompra;
    }
}