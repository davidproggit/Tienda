
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
            this.ColNombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCategoriaProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSubcategoriaProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidadProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSeleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblCategoriaProd = new System.Windows.Forms.Label();
            this.cboxCategoria = new System.Windows.Forms.ComboBox();
            this.lblSubcategoriaProd = new System.Windows.Forms.Label();
            this.cBoxSubcategoriaProd = new System.Windows.Forms.ComboBox();
            this.btnCompraProd = new System.Windows.Forms.Button();
            this.btnQuitarProd = new System.Windows.Forms.Button();
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
            this.ColCategoriaProd,
            this.ColSubcategoriaProd,
            this.ColCantidadProd,
            this.ColSeleccionar});
            this.dataGridView1.Location = new System.Drawing.Point(110, 246);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 62);
            this.dataGridView1.TabIndex = 4;
            // 
            // ColNombreProducto
            // 
            this.ColNombreProducto.HeaderText = "Nombre";
            this.ColNombreProducto.Name = "ColNombreProducto";
            // 
            // ColCategoriaProd
            // 
            this.ColCategoriaProd.HeaderText = "Categoria";
            this.ColCategoriaProd.Name = "ColCategoriaProd";
            // 
            // ColSubcategoriaProd
            // 
            this.ColSubcategoriaProd.HeaderText = "Subcategoria";
            this.ColSubcategoriaProd.Name = "ColSubcategoriaProd";
            // 
            // ColCantidadProd
            // 
            this.ColCantidadProd.HeaderText = "Cantidad";
            this.ColCantidadProd.Name = "ColCantidadProd";
            // 
            // ColSeleccionar
            // 
            this.ColSeleccionar.HeaderText = "Seleccionar";
            this.ColSeleccionar.Name = "ColSeleccionar";
            this.ColSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColSeleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // lblCategoriaProd
            // 
            this.lblCategoriaProd.AutoSize = true;
            this.lblCategoriaProd.Location = new System.Drawing.Point(53, 166);
            this.lblCategoriaProd.Name = "lblCategoriaProd";
            this.lblCategoriaProd.Size = new System.Drawing.Size(55, 13);
            this.lblCategoriaProd.TabIndex = 5;
            this.lblCategoriaProd.Text = "Categoria:";
            // 
            // cboxCategoria
            // 
            this.cboxCategoria.FormattingEnabled = true;
            this.cboxCategoria.Location = new System.Drawing.Point(110, 163);
            this.cboxCategoria.Name = "cboxCategoria";
            this.cboxCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboxCategoria.TabIndex = 6;
            // 
            // lblSubcategoriaProd
            // 
            this.lblSubcategoriaProd.AutoSize = true;
            this.lblSubcategoriaProd.Location = new System.Drawing.Point(296, 166);
            this.lblSubcategoriaProd.Name = "lblSubcategoriaProd";
            this.lblSubcategoriaProd.Size = new System.Drawing.Size(73, 13);
            this.lblSubcategoriaProd.TabIndex = 7;
            this.lblSubcategoriaProd.Text = "Subcategoria:";
            // 
            // cBoxSubcategoriaProd
            // 
            this.cBoxSubcategoriaProd.FormattingEnabled = true;
            this.cBoxSubcategoriaProd.Location = new System.Drawing.Point(386, 163);
            this.cBoxSubcategoriaProd.Name = "cBoxSubcategoriaProd";
            this.cBoxSubcategoriaProd.Size = new System.Drawing.Size(121, 21);
            this.cBoxSubcategoriaProd.TabIndex = 9;
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
            // ABMCompraProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuitarProd);
            this.Controls.Add(this.btnCompraProd);
            this.Controls.Add(this.cBoxSubcategoriaProd);
            this.Controls.Add(this.lblSubcategoriaProd);
            this.Controls.Add(this.cboxCategoria);
            this.Controls.Add(this.lblCategoriaProd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuscarProd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNombreprod);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCategoriaProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSubcategoriaProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidadProd;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColSeleccionar;
        private System.Windows.Forms.Label lblCategoriaProd;
        private System.Windows.Forms.ComboBox cboxCategoria;
        private System.Windows.Forms.Label lblSubcategoriaProd;
        private System.Windows.Forms.ComboBox cBoxSubcategoriaProd;
        private System.Windows.Forms.Button btnCompraProd;
        private System.Windows.Forms.Button btnQuitarProd;
    }
}