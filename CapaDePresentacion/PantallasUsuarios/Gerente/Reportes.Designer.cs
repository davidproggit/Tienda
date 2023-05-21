
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblFechadesdeProd = new System.Windows.Forms.Label();
            this.dtpFechaDesdeProd = new System.Windows.Forms.DateTimePicker();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaHastaProd = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarProd = new System.Windows.Forms.Button();
            this.btnCancelarProd = new System.Windows.Forms.Button();
            this.btnDescargarReporte = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.tboxCantidad = new System.Windows.Forms.TextBox();
            this.ColNombreProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCanVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFechaDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFechaHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStockProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSeleccionarProd = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descargar reportes de productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 20);
            this.textBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNombreProd,
            this.ColCanVenta,
            this.ColFechaDesde,
            this.ColFechaHasta,
            this.ColStockProd,
            this.ColSeleccionarProd});
            this.dataGridView1.Location = new System.Drawing.Point(12, 282);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(776, 100);
            this.dataGridView1.TabIndex = 7;
            // 
            // lblFechadesdeProd
            // 
            this.lblFechadesdeProd.AutoSize = true;
            this.lblFechadesdeProd.Location = new System.Drawing.Point(276, 120);
            this.lblFechadesdeProd.Name = "lblFechadesdeProd";
            this.lblFechadesdeProd.Size = new System.Drawing.Size(72, 13);
            this.lblFechadesdeProd.TabIndex = 8;
            this.lblFechadesdeProd.Text = "Fecha desde:";
            // 
            // dtpFechaDesdeProd
            // 
            this.dtpFechaDesdeProd.Location = new System.Drawing.Point(352, 114);
            this.dtpFechaDesdeProd.Name = "dtpFechaDesdeProd";
            this.dtpFechaDesdeProd.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaDesdeProd.TabIndex = 9;
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(277, 172);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(69, 13);
            this.lblFechaHasta.TabIndex = 10;
            this.lblFechaHasta.Text = "Fecha hasta:";
            // 
            // dtpFechaHastaProd
            // 
            this.dtpFechaHastaProd.Location = new System.Drawing.Point(352, 166);
            this.dtpFechaHastaProd.Name = "dtpFechaHastaProd";
            this.dtpFechaHastaProd.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaHastaProd.TabIndex = 11;
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.Location = new System.Drawing.Point(657, 228);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarProd.TabIndex = 12;
            this.btnBuscarProd.Text = "Buscar ";
            this.btnBuscarProd.UseVisualStyleBackColor = true;
            // 
            // btnCancelarProd
            // 
            this.btnCancelarProd.Location = new System.Drawing.Point(551, 228);
            this.btnCancelarProd.Name = "btnCancelarProd";
            this.btnCancelarProd.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarProd.TabIndex = 13;
            this.btnCancelarProd.Text = "Cancelar";
            this.btnCancelarProd.UseVisualStyleBackColor = true;
            // 
            // btnDescargarReporte
            // 
            this.btnDescargarReporte.Location = new System.Drawing.Point(657, 397);
            this.btnDescargarReporte.Name = "btnDescargarReporte";
            this.btnDescargarReporte.Size = new System.Drawing.Size(75, 23);
            this.btnDescargarReporte.TabIndex = 14;
            this.btnDescargarReporte.Text = "Descargar reporte";
            this.btnDescargarReporte.UseVisualStyleBackColor = true;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(38, 177);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 15;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // tboxCantidad
            // 
            this.tboxCantidad.Location = new System.Drawing.Point(91, 174);
            this.tboxCantidad.Name = "tboxCantidad";
            this.tboxCantidad.Size = new System.Drawing.Size(128, 20);
            this.tboxCantidad.TabIndex = 16;
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
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tboxCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnDescargarReporte);
            this.Controls.Add(this.btnCancelarProd);
            this.Controls.Add(this.btnBuscarProd);
            this.Controls.Add(this.dtpFechaHastaProd);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.dtpFechaDesdeProd);
            this.Controls.Add(this.lblFechadesdeProd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reportes";
            this.Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblFechadesdeProd;
        private System.Windows.Forms.DateTimePicker dtpFechaDesdeProd;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaHastaProd;
        private System.Windows.Forms.Button btnBuscarProd;
        private System.Windows.Forms.Button btnCancelarProd;
        private System.Windows.Forms.Button btnDescargarReporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombreProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCanVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFechaDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFechaHasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStockProd;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColSeleccionarProd;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox tboxCantidad;
    }
}