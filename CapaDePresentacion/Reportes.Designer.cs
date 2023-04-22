
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
            this.lblCategoriaProd = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblSubcategoria = new System.Windows.Forms.Label();
            this.cBoxSubcategoria = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColNombreProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCategoriaProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSubcategoriaProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStockProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSeleccionarProd = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblFechadesdeProd = new System.Windows.Forms.Label();
            this.dtpFechaDesdeProd = new System.Windows.Forms.DateTimePicker();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaHastaProd = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarProd = new System.Windows.Forms.Button();
            this.btnCancelarProd = new System.Windows.Forms.Button();
            this.btnDescargarReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(474, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descargar reportes de productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 171);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 26);
            this.textBox1.TabIndex = 2;
            // 
            // lblCategoriaProd
            // 
            this.lblCategoriaProd.AutoSize = true;
            this.lblCategoriaProd.Location = new System.Drawing.Point(396, 177);
            this.lblCategoriaProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoriaProd.Name = "lblCategoriaProd";
            this.lblCategoriaProd.Size = new System.Drawing.Size(82, 20);
            this.lblCategoriaProd.TabIndex = 3;
            this.lblCategoriaProd.Text = "Categoria:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(478, 169);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 28);
            this.comboBox1.TabIndex = 4;
            // 
            // lblSubcategoria
            // 
            this.lblSubcategoria.AutoSize = true;
            this.lblSubcategoria.Location = new System.Drawing.Point(724, 177);
            this.lblSubcategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubcategoria.Name = "lblSubcategoria";
            this.lblSubcategoria.Size = new System.Drawing.Size(108, 20);
            this.lblSubcategoria.TabIndex = 5;
            this.lblSubcategoria.Text = "Subcategoria:";
            // 
            // cBoxSubcategoria
            // 
            this.cBoxSubcategoria.FormattingEnabled = true;
            this.cBoxSubcategoria.Location = new System.Drawing.Point(843, 172);
            this.cBoxSubcategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cBoxSubcategoria.Name = "cBoxSubcategoria";
            this.cBoxSubcategoria.Size = new System.Drawing.Size(217, 28);
            this.cBoxSubcategoria.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNombreProd,
            this.ColCategoriaProd,
            this.ColSubcategoriaProd,
            this.ColStockProd,
            this.ColFechaIngreso,
            this.ColSeleccionarProd});
            this.dataGridView1.Location = new System.Drawing.Point(118, 463);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(962, 92);
            this.dataGridView1.TabIndex = 7;
            // 
            // ColNombreProd
            // 
            this.ColNombreProd.HeaderText = "Nombre ";
            this.ColNombreProd.MinimumWidth = 8;
            this.ColNombreProd.Name = "ColNombreProd";
            this.ColNombreProd.Width = 150;
            // 
            // ColCategoriaProd
            // 
            this.ColCategoriaProd.HeaderText = "Categoria";
            this.ColCategoriaProd.MinimumWidth = 8;
            this.ColCategoriaProd.Name = "ColCategoriaProd";
            this.ColCategoriaProd.Width = 150;
            // 
            // ColSubcategoriaProd
            // 
            this.ColSubcategoriaProd.HeaderText = "Subcategoria";
            this.ColSubcategoriaProd.MinimumWidth = 8;
            this.ColSubcategoriaProd.Name = "ColSubcategoriaProd";
            this.ColSubcategoriaProd.Width = 150;
            // 
            // ColStockProd
            // 
            this.ColStockProd.HeaderText = "Stock";
            this.ColStockProd.MinimumWidth = 8;
            this.ColStockProd.Name = "ColStockProd";
            this.ColStockProd.Width = 150;
            // 
            // ColFechaIngreso
            // 
            this.ColFechaIngreso.HeaderText = "Fecha Ingreso";
            this.ColFechaIngreso.MinimumWidth = 8;
            this.ColFechaIngreso.Name = "ColFechaIngreso";
            this.ColFechaIngreso.Width = 150;
            // 
            // ColSeleccionarProd
            // 
            this.ColSeleccionarProd.HeaderText = "Seleccionar";
            this.ColSeleccionarProd.MinimumWidth = 8;
            this.ColSeleccionarProd.Name = "ColSeleccionarProd";
            this.ColSeleccionarProd.Width = 150;
            // 
            // lblFechadesdeProd
            // 
            this.lblFechadesdeProd.AutoSize = true;
            this.lblFechadesdeProd.Location = new System.Drawing.Point(112, 277);
            this.lblFechadesdeProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechadesdeProd.Name = "lblFechadesdeProd";
            this.lblFechadesdeProd.Size = new System.Drawing.Size(106, 20);
            this.lblFechadesdeProd.TabIndex = 8;
            this.lblFechadesdeProd.Text = "Fecha desde:";
            // 
            // dtpFechaDesdeProd
            // 
            this.dtpFechaDesdeProd.Location = new System.Drawing.Point(226, 268);
            this.dtpFechaDesdeProd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaDesdeProd.Name = "dtpFechaDesdeProd";
            this.dtpFechaDesdeProd.Size = new System.Drawing.Size(298, 26);
            this.dtpFechaDesdeProd.TabIndex = 9;
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(626, 277);
            this.lblFechaHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(102, 20);
            this.lblFechaHasta.TabIndex = 10;
            this.lblFechaHasta.Text = "Fecha hasta:";
            // 
            // dtpFechaHastaProd
            // 
            this.dtpFechaHastaProd.Location = new System.Drawing.Point(738, 268);
            this.dtpFechaHastaProd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaHastaProd.Name = "dtpFechaHastaProd";
            this.dtpFechaHastaProd.Size = new System.Drawing.Size(298, 26);
            this.dtpFechaHastaProd.TabIndex = 11;
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.Location = new System.Drawing.Point(986, 351);
            this.btnBuscarProd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Size = new System.Drawing.Size(112, 35);
            this.btnBuscarProd.TabIndex = 12;
            this.btnBuscarProd.Text = "Buscar ";
            this.btnBuscarProd.UseVisualStyleBackColor = true;
            // 
            // btnCancelarProd
            // 
            this.btnCancelarProd.Location = new System.Drawing.Point(826, 351);
            this.btnCancelarProd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelarProd.Name = "btnCancelarProd";
            this.btnCancelarProd.Size = new System.Drawing.Size(112, 35);
            this.btnCancelarProd.TabIndex = 13;
            this.btnCancelarProd.Text = "Cancelar";
            this.btnCancelarProd.UseVisualStyleBackColor = true;
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
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnDescargarReporte);
            this.Controls.Add(this.btnCancelarProd);
            this.Controls.Add(this.btnBuscarProd);
            this.Controls.Add(this.dtpFechaHastaProd);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.dtpFechaDesdeProd);
            this.Controls.Add(this.lblFechadesdeProd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cBoxSubcategoria);
            this.Controls.Add(this.lblSubcategoria);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblCategoriaProd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Label lblCategoriaProd;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblSubcategoria;
        private System.Windows.Forms.ComboBox cBoxSubcategoria;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombreProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCategoriaProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSubcategoriaProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStockProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFechaIngreso;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColSeleccionarProd;
        private System.Windows.Forms.Label lblFechadesdeProd;
        private System.Windows.Forms.DateTimePicker dtpFechaDesdeProd;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaHastaProd;
        private System.Windows.Forms.Button btnBuscarProd;
        private System.Windows.Forms.Button btnCancelarProd;
        private System.Windows.Forms.Button btnDescargarReporte;
    }
}