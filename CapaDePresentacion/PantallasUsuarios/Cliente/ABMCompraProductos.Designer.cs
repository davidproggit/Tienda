
namespace CapaDePresentacion
{
    partial class ABMCompraProductos
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
            this.lblNombreprod = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscarProd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCompraProd = new System.Windows.Forms.Button();
            this.btnQuitarProd = new System.Windows.Forms.Button();
            this.ColNombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStockProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSeleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comprar productos";
            // 
            // lblNombreprod
            // 
            this.lblNombreprod.AutoSize = true;
            this.lblNombreprod.Location = new System.Drawing.Point(41, 106);
            this.lblNombreprod.Name = "lblNombreprod";
            this.lblNombreprod.Size = new System.Drawing.Size(47, 13);
            this.lblNombreprod.TabIndex = 1;
            this.lblNombreprod.Text = "Nombre:";
            this.lblNombreprod.UseWaitCursor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(557, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.Location = new System.Drawing.Point(678, 101);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarProd.TabIndex = 3;
            this.btnBuscarProd.Text = "Buscar";
            this.btnBuscarProd.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNombreProducto,
            this.ColPrecio,
            this.ColDescripcion,
            this.ColMarca,
            this.ColStockProd,
            this.ColSeleccionar});
            this.dataGridView1.Location = new System.Drawing.Point(115, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(554, 85);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnCompraProd
            // 
            this.btnCompraProd.Location = new System.Drawing.Point(678, 390);
            this.btnCompraProd.Name = "btnCompraProd";
            this.btnCompraProd.Size = new System.Drawing.Size(75, 23);
            this.btnCompraProd.TabIndex = 10;
            this.btnCompraProd.Text = "Comprar";
            this.btnCompraProd.UseVisualStyleBackColor = true;
            // 
            // btnQuitarProd
            // 
            this.btnQuitarProd.Location = new System.Drawing.Point(576, 390);
            this.btnQuitarProd.Name = "btnQuitarProd";
            this.btnQuitarProd.Size = new System.Drawing.Size(75, 23);
            this.btnQuitarProd.TabIndex = 11;
            this.btnQuitarProd.Text = "Quitar";
            this.btnQuitarProd.UseVisualStyleBackColor = true;
            // 
            // ColNombreProducto
            // 
            this.ColNombreProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColNombreProducto.HeaderText = "Nombre";
            this.ColNombreProducto.MinimumWidth = 8;
            this.ColNombreProducto.Name = "ColNombreProducto";
            this.ColNombreProducto.Width = 69;
            // 
            // ColPrecio
            // 
            this.ColPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColPrecio.HeaderText = "Precio";
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.Width = 62;
            // 
            // ColDescripcion
            // 
            this.ColDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColDescripcion.HeaderText = "Descripcion";
            this.ColDescripcion.Name = "ColDescripcion";
            this.ColDescripcion.Width = 88;
            // 
            // ColMarca
            // 
            this.ColMarca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColMarca.HeaderText = "Marca";
            this.ColMarca.Name = "ColMarca";
            this.ColMarca.Width = 62;
            // 
            // ColStockProd
            // 
            this.ColStockProd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColStockProd.HeaderText = "Stock";
            this.ColStockProd.MinimumWidth = 8;
            this.ColStockProd.Name = "ColStockProd";
            this.ColStockProd.Width = 60;
            // 
            // ColSeleccionar
            // 
            this.ColSeleccionar.HeaderText = "Seleccionar";
            this.ColSeleccionar.MinimumWidth = 8;
            this.ColSeleccionar.Name = "ColSeleccionar";
            this.ColSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColSeleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColSeleccionar.Width = 150;
            // 
            // ABMCompraProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuitarProd);
            this.Controls.Add(this.btnCompraProd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuscarProd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNombreprod);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ABMCompraProductos";
            this.Text = "Compra de Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombreprod;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBuscarProd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCompraProd;
        private System.Windows.Forms.Button btnQuitarProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStockProd;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColSeleccionar;
    }
}