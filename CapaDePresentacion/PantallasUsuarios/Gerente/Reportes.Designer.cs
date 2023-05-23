
namespace CapaDePresentacion
{
    partial class Reportes
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.grillaProductosReporte = new System.Windows.Forms.DataGridView();
            this.ColNombreProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCanVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFechaDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFechaHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStockProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSeleccionarProd = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblFechadesde = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.btnCancelarProducto = new System.Windows.Forms.Button();
            this.btnDescargarReporte = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProductosReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(474, 63);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(243, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Descargar reportes de productos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(64, 180);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(136, 175);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(190, 26);
            this.txtNombre.TabIndex = 2;
            // 
            // grillaProductosReporte
            // 
            this.grillaProductosReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaProductosReporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNombreProd,
            this.ColCanVenta,
            this.ColFechaDesde,
            this.ColFechaHasta,
            this.ColStockProd,
            this.ColSeleccionarProd});
            this.grillaProductosReporte.Location = new System.Drawing.Point(18, 434);
            this.grillaProductosReporte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grillaProductosReporte.Name = "grillaProductosReporte";
            this.grillaProductosReporte.RowHeadersWidth = 62;
            this.grillaProductosReporte.Size = new System.Drawing.Size(1164, 154);
            this.grillaProductosReporte.TabIndex = 7;
            // 
            // ColNombreProd
            // 
            this.ColNombreProd.HeaderText = "Nombre Producto ";
            this.ColNombreProd.MinimumWidth = 8;
            this.ColNombreProd.Name = "ColNombreProd";
            this.ColNombreProd.Width = 150;
            // 
            // ColCanVenta
            // 
            this.ColCanVenta.HeaderText = "Cantidad Venta";
            this.ColCanVenta.MinimumWidth = 8;
            this.ColCanVenta.Name = "ColCanVenta";
            this.ColCanVenta.Width = 150;
            // 
            // ColFechaDesde
            // 
            this.ColFechaDesde.HeaderText = "Fecha Desde";
            this.ColFechaDesde.MinimumWidth = 8;
            this.ColFechaDesde.Name = "ColFechaDesde";
            this.ColFechaDesde.Width = 150;
            // 
            // ColFechaHasta
            // 
            this.ColFechaHasta.HeaderText = "Fecha Hasta";
            this.ColFechaHasta.MinimumWidth = 8;
            this.ColFechaHasta.Name = "ColFechaHasta";
            this.ColFechaHasta.Width = 150;
            // 
            // ColStockProd
            // 
            this.ColStockProd.HeaderText = "Stock";
            this.ColStockProd.MinimumWidth = 8;
            this.ColStockProd.Name = "ColStockProd";
            this.ColStockProd.Width = 150;
            // 
            // ColSeleccionarProd
            // 
            this.ColSeleccionarProd.HeaderText = "Seleccionar";
            this.ColSeleccionarProd.MinimumWidth = 8;
            this.ColSeleccionarProd.Name = "ColSeleccionarProd";
            this.ColSeleccionarProd.Width = 150;
            // 
            // lblFechadesde
            // 
            this.lblFechadesde.AutoSize = true;
            this.lblFechadesde.Location = new System.Drawing.Point(414, 185);
            this.lblFechadesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechadesde.Name = "lblFechadesde";
            this.lblFechadesde.Size = new System.Drawing.Size(106, 20);
            this.lblFechadesde.TabIndex = 8;
            this.lblFechadesde.Text = "Fecha desde:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(528, 175);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(298, 26);
            this.dtpFechaDesde.TabIndex = 9;
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(416, 265);
            this.lblFechaHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(102, 20);
            this.lblFechaHasta.TabIndex = 10;
            this.lblFechaHasta.Text = "Fecha hasta:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(528, 255);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(298, 26);
            this.dtpFechaHasta.TabIndex = 11;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(986, 351);
            this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(112, 35);
            this.btnBuscarProducto.TabIndex = 12;
            this.btnBuscarProducto.Text = "Buscar ";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            // 
            // btnCancelarProducto
            // 
            this.btnCancelarProducto.Location = new System.Drawing.Point(826, 351);
            this.btnCancelarProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelarProducto.Name = "btnCancelarProducto";
            this.btnCancelarProducto.Size = new System.Drawing.Size(112, 35);
            this.btnCancelarProducto.TabIndex = 13;
            this.btnCancelarProducto.Text = "Cancelar";
            this.btnCancelarProducto.UseVisualStyleBackColor = true;
            // 
            // btnDescargarReporte
            // 
            this.btnDescargarReporte.Location = new System.Drawing.Point(986, 611);
            this.btnDescargarReporte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDescargarReporte.Name = "btnDescargarReporte";
            this.btnDescargarReporte.Size = new System.Drawing.Size(112, 35);
            this.btnDescargarReporte.TabIndex = 14;
            this.btnDescargarReporte.Text = "Descargar reporte";
            this.btnDescargarReporte.UseVisualStyleBackColor = true;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(57, 272);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(77, 20);
            this.lblCantidad.TabIndex = 15;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(136, 268);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(190, 26);
            this.txtCantidad.TabIndex = 16;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnDescargarReporte);
            this.Controls.Add(this.btnCancelarProducto);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.lblFechadesde);
            this.Controls.Add(this.grillaProductosReporte);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Reportes";
            this.Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.grillaProductosReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView grillaProductosReporte;
        private System.Windows.Forms.Label lblFechadesde;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Button btnCancelarProducto;
        private System.Windows.Forms.Button btnDescargarReporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombreProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCanVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFechaDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFechaHasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStockProd;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColSeleccionarProd;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
    }
}