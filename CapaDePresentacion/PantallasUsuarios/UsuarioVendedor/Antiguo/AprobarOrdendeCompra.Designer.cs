
namespace CapaDePresentacion.PantallasUsuarios.UsuarioVendedor
{
    partial class AprobarOrdendeCompra
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAprobar = new System.Windows.Forms.Button();
            this.btnRechazar = new System.Windows.Forms.Button();
            this.ColNomCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNomProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecioProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidadProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMediodePago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSeleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnDetalleOC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaOrdenes)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaOrdenes
            // 
            this.grillaOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaOrdenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNomCliente,
            this.ColApellido,
            this.ColDNI,
            this.ColEmail,
            this.ColNomProd,
            this.ColDescProducto,
            this.ColMarca,
            this.ColPrecioProd,
            this.ColCantidadProd,
            this.ColMediodePago,
            this.ColSeleccionar});
            this.grillaOrdenes.Location = new System.Drawing.Point(26, 161);
            this.grillaOrdenes.Name = "grillaOrdenes";
            this.grillaOrdenes.RowHeadersWidth = 62;
            this.grillaOrdenes.Size = new System.Drawing.Size(994, 150);
            this.grillaOrdenes.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(399, 50);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(228, 20);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Gestión de ordenes de compra";
            this.lblTitulo.UseMnemonic = false;
            // 
            // btnAprobar
            // 
            this.btnAprobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAprobar.Location = new System.Drawing.Point(783, 387);
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Size = new System.Drawing.Size(93, 38);
            this.btnAprobar.TabIndex = 2;
            this.btnAprobar.Text = "Aprobar";
            this.btnAprobar.UseVisualStyleBackColor = true;
            // 
            // btnRechazar
            // 
            this.btnRechazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechazar.Location = new System.Drawing.Point(904, 387);
            this.btnRechazar.Name = "btnRechazar";
            this.btnRechazar.Size = new System.Drawing.Size(91, 38);
            this.btnRechazar.TabIndex = 3;
            this.btnRechazar.Text = "Rechazar";
            this.btnRechazar.UseVisualStyleBackColor = true;
            // 
            // ColNomCliente
            // 
            this.ColNomCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColNomCliente.HeaderText = "Nombre Cliente";
            this.ColNomCliente.MinimumWidth = 8;
            this.ColNomCliente.Name = "ColNomCliente";
            this.ColNomCliente.Width = 96;
            // 
            // ColApellido
            // 
            this.ColApellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColApellido.HeaderText = "Apellido";
            this.ColApellido.MinimumWidth = 8;
            this.ColApellido.Name = "ColApellido";
            this.ColApellido.Width = 69;
            // 
            // ColDNI
            // 
            this.ColDNI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColDNI.HeaderText = "DNI";
            this.ColDNI.MinimumWidth = 8;
            this.ColDNI.Name = "ColDNI";
            this.ColDNI.Width = 51;
            // 
            // ColEmail
            // 
            this.ColEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColEmail.HeaderText = "Email";
            this.ColEmail.MinimumWidth = 8;
            this.ColEmail.Name = "ColEmail";
            this.ColEmail.Width = 57;
            // 
            // ColNomProd
            // 
            this.ColNomProd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColNomProd.HeaderText = "Nombre Producto";
            this.ColNomProd.MinimumWidth = 8;
            this.ColNomProd.Name = "ColNomProd";
            this.ColNomProd.Width = 105;
            // 
            // ColDescProducto
            // 
            this.ColDescProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColDescProducto.HeaderText = "Descripcion";
            this.ColDescProducto.MinimumWidth = 8;
            this.ColDescProducto.Name = "ColDescProducto";
            this.ColDescProducto.Width = 88;
            // 
            // ColMarca
            // 
            this.ColMarca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColMarca.HeaderText = "Marca";
            this.ColMarca.MinimumWidth = 8;
            this.ColMarca.Name = "ColMarca";
            this.ColMarca.Width = 62;
            // 
            // ColPrecioProd
            // 
            this.ColPrecioProd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColPrecioProd.HeaderText = "Precio Unitario";
            this.ColPrecioProd.MinimumWidth = 8;
            this.ColPrecioProd.Name = "ColPrecioProd";
            this.ColPrecioProd.Width = 93;
            // 
            // ColCantidadProd
            // 
            this.ColCantidadProd.HeaderText = "Cantidad de productos";
            this.ColCantidadProd.Name = "ColCantidadProd";
            // 
            // ColMediodePago
            // 
            this.ColMediodePago.HeaderText = "Medio de pago";
            this.ColMediodePago.Name = "ColMediodePago";
            // 
            // ColSeleccionar
            // 
            this.ColSeleccionar.HeaderText = "Seleccionar";
            this.ColSeleccionar.MinimumWidth = 8;
            this.ColSeleccionar.Name = "ColSeleccionar";
            this.ColSeleccionar.Width = 150;
            // 
            // btnDetalleOC
            // 
            this.btnDetalleOC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalleOC.Location = new System.Drawing.Point(620, 387);
            this.btnDetalleOC.Name = "btnDetalleOC";
            this.btnDetalleOC.Size = new System.Drawing.Size(128, 50);
            this.btnDetalleOC.TabIndex = 4;
            this.btnDetalleOC.Text = "Ver detalle de OC";
            this.btnDetalleOC.UseVisualStyleBackColor = true;
            // 
            // AprobarOrdendeCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 521);
            this.Controls.Add(this.btnDetalleOC);
            this.Controls.Add(this.btnRechazar);
            this.Controls.Add(this.btnAprobar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grillaOrdenes);
            this.Name = "AprobarOrdendeCompra";
            this.Text = "AprobarOrdendeCompra";
            ((System.ComponentModel.ISupportInitialize)(this.grillaOrdenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaOrdenes;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAprobar;
        private System.Windows.Forms.Button btnRechazar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNomCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNomProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecioProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidadProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMediodePago;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColSeleccionar;
        private System.Windows.Forms.Button btnDetalleOC;
    }
}