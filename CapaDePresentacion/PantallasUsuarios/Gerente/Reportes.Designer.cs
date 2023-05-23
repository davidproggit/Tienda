
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
            this.panelControlReportes = new System.Windows.Forms.Panel();
            this.panelAccion = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProductosReporte)).BeginInit();
            this.panelControlReportes.SuspendLayout();
            this.panelAccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(474, 63);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(367, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Descargar reportes de productos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(24, 18);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(107, 29);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(139, 15);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(190, 35);
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
            this.grillaProductosReporte.Size = new System.Drawing.Size(1022, 154);
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
            this.lblFechadesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechadesde.Location = new System.Drawing.Point(366, 15);
            this.lblFechadesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechadesde.Name = "lblFechadesde";
            this.lblFechadesde.Size = new System.Drawing.Size(160, 29);
            this.lblFechadesde.TabIndex = 8;
            this.lblFechadesde.Text = "Fecha desde:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDesde.Location = new System.Drawing.Point(534, 15);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(460, 35);
            this.dtpFechaDesde.TabIndex = 9;
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHasta.Location = new System.Drawing.Point(368, 95);
            this.lblFechaHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(149, 29);
            this.lblFechaHasta.TabIndex = 10;
            this.lblFechaHasta.Text = "Fecha hasta:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaHasta.Location = new System.Drawing.Point(534, 89);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(460, 35);
            this.dtpFechaHasta.TabIndex = 11;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.Location = new System.Drawing.Point(168, 20);
            this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(137, 50);
            this.btnBuscarProducto.TabIndex = 12;
            this.btnBuscarProducto.Text = "Buscar ";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            // 
            // btnCancelarProducto
            // 
            this.btnCancelarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarProducto.Location = new System.Drawing.Point(14, 20);
            this.btnCancelarProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelarProducto.Name = "btnCancelarProducto";
            this.btnCancelarProducto.Size = new System.Drawing.Size(132, 50);
            this.btnCancelarProducto.TabIndex = 13;
            this.btnCancelarProducto.Text = "Cancelar";
            this.btnCancelarProducto.UseVisualStyleBackColor = true;
            // 
            // btnDescargarReporte
            // 
            this.btnDescargarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargarReporte.Location = new System.Drawing.Point(726, 611);
            this.btnDescargarReporte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDescargarReporte.Name = "btnDescargarReporte";
            this.btnDescargarReporte.Size = new System.Drawing.Size(282, 67);
            this.btnDescargarReporte.TabIndex = 14;
            this.btnDescargarReporte.Text = "Descargar reporte";
            this.btnDescargarReporte.UseVisualStyleBackColor = true;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(17, 107);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(115, 29);
            this.lblCantidad.TabIndex = 15;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(139, 101);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(190, 35);
            this.txtCantidad.TabIndex = 16;
            // 
            // panelControlReportes
            // 
            this.panelControlReportes.BackColor = System.Drawing.Color.LightGray;
            this.panelControlReportes.Controls.Add(this.lblNombre);
            this.panelControlReportes.Controls.Add(this.txtCantidad);
            this.panelControlReportes.Controls.Add(this.txtNombre);
            this.panelControlReportes.Controls.Add(this.lblCantidad);
            this.panelControlReportes.Controls.Add(this.lblFechadesde);
            this.panelControlReportes.Controls.Add(this.dtpFechaDesde);
            this.panelControlReportes.Controls.Add(this.lblFechaHasta);
            this.panelControlReportes.Controls.Add(this.dtpFechaHasta);
            this.panelControlReportes.Location = new System.Drawing.Point(18, 143);
            this.panelControlReportes.Name = "panelControlReportes";
            this.panelControlReportes.Size = new System.Drawing.Size(1022, 154);
            this.panelControlReportes.TabIndex = 17;
            // 
            // panelAccion
            // 
            this.panelAccion.BackColor = System.Drawing.Color.LightGray;
            this.panelAccion.Controls.Add(this.btnCancelarProducto);
            this.panelAccion.Controls.Add(this.btnBuscarProducto);
            this.panelAccion.Location = new System.Drawing.Point(719, 315);
            this.panelAccion.Name = "panelAccion";
            this.panelAccion.Size = new System.Drawing.Size(321, 89);
            this.panelAccion.TabIndex = 18;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panelAccion);
            this.Controls.Add(this.panelControlReportes);
            this.Controls.Add(this.btnDescargarReporte);
            this.Controls.Add(this.grillaProductosReporte);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Reportes";
            this.Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.grillaProductosReporte)).EndInit();
            this.panelControlReportes.ResumeLayout(false);
            this.panelControlReportes.PerformLayout();
            this.panelAccion.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelControlReportes;
        private System.Windows.Forms.Panel panelAccion;
    }
}