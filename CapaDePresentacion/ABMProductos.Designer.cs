
namespace CapaDePresentacion
{
    partial class ABMProductos
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
            this.components = new System.ComponentModel.Container();
            this.btnAltaProducto = new System.Windows.Forms.Button();
            this.lblProductos = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.txtBoxNombreProducto = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboxCategoria = new System.Windows.Forms.ComboBox();
            this.lblSubcategoria = new System.Windows.Forms.Label();
            this.cboxSubcategoria = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtBoxCantidad = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSubcategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSeleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGenerarAlerta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAltaProducto
            // 
            this.btnAltaProducto.Location = new System.Drawing.Point(966, 297);
            this.btnAltaProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAltaProducto.Name = "btnAltaProducto";
            this.btnAltaProducto.Size = new System.Drawing.Size(117, 45);
            this.btnAltaProducto.TabIndex = 0;
            this.btnAltaProducto.Text = "Agregar ";
            this.btnAltaProducto.UseVisualStyleBackColor = true;
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Location = new System.Drawing.Point(498, 65);
            this.lblProductos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(164, 20);
            this.lblProductos.TabIndex = 1;
            this.lblProductos.Text = "Administrar productos";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(78, 182);
            this.lblNombreProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(69, 20);
            this.lblNombreProducto.TabIndex = 2;
            this.lblNombreProducto.Text = "Nombre:";
            // 
            // txtBoxNombreProducto
            // 
            this.txtBoxNombreProducto.Location = new System.Drawing.Point(158, 177);
            this.txtBoxNombreProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxNombreProducto.Name = "txtBoxNombreProducto";
            this.txtBoxNombreProducto.Size = new System.Drawing.Size(148, 26);
            this.txtBoxNombreProducto.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(390, 182);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(82, 20);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoria:";
            // 
            // cboxCategoria
            // 
            this.cboxCategoria.FormattingEnabled = true;
            this.cboxCategoria.Items.AddRange(new object[] {
            "Muebles ",
            "Cocina ",
            "Baño",
            "Deco Hogar",
            "Textil",
            "Uso Personal",
            "Escritorio",
            "Organizadores",
            "Niños",
            "Marcas Destacadas"});
            this.cboxCategoria.Location = new System.Drawing.Point(478, 175);
            this.cboxCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxCategoria.Name = "cboxCategoria";
            this.cboxCategoria.Size = new System.Drawing.Size(180, 28);
            this.cboxCategoria.TabIndex = 6;
            // 
            // lblSubcategoria
            // 
            this.lblSubcategoria.AutoSize = true;
            this.lblSubcategoria.Location = new System.Drawing.Point(758, 182);
            this.lblSubcategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubcategoria.Name = "lblSubcategoria";
            this.lblSubcategoria.Size = new System.Drawing.Size(108, 20);
            this.lblSubcategoria.TabIndex = 7;
            this.lblSubcategoria.Text = "Subcategoria:";
            // 
            // cboxSubcategoria
            // 
            this.cboxSubcategoria.FormattingEnabled = true;
            this.cboxSubcategoria.Items.AddRange(new object[] {
            "Exterior",
            "Escritorios",
            "Estanterias y Bibliotecas",
            "Sillones y Sofás",
            "Mesas ratonas y auxiliares",
            "Mesas de TV y consolas",
            "Mesas de comedor",
            "Sillas y banquetas"});
            this.cboxSubcategoria.Location = new System.Drawing.Point(876, 175);
            this.cboxSubcategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxSubcategoria.Name = "cboxSubcategoria";
            this.cboxSubcategoria.Size = new System.Drawing.Size(180, 28);
            this.cboxSubcategoria.TabIndex = 8;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(70, 297);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(77, 20);
            this.lblCantidad.TabIndex = 9;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtBoxCantidad
            // 
            this.txtBoxCantidad.Location = new System.Drawing.Point(158, 292);
            this.txtBoxCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxCantidad.Name = "txtBoxCantidad";
            this.txtBoxCantidad.Size = new System.Drawing.Size(148, 26);
            this.txtBoxCantidad.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNombre,
            this.ColCategoria,
            this.ColSubcategoria,
            this.ColCantidad,
            this.ColStock,
            this.ColSeleccionar});
            this.dataGridView1.Location = new System.Drawing.Point(124, 406);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(958, 198);
            this.dataGridView1.TabIndex = 11;
            // 
            // ColNombre
            // 
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.MinimumWidth = 8;
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.Width = 150;
            // 
            // ColCategoria
            // 
            this.ColCategoria.HeaderText = "Categoria";
            this.ColCategoria.MinimumWidth = 8;
            this.ColCategoria.Name = "ColCategoria";
            this.ColCategoria.Width = 150;
            // 
            // ColSubcategoria
            // 
            this.ColSubcategoria.HeaderText = "Subcategoria";
            this.ColSubcategoria.MinimumWidth = 8;
            this.ColSubcategoria.Name = "ColSubcategoria";
            this.ColSubcategoria.Width = 150;
            // 
            // ColCantidad
            // 
            this.ColCantidad.HeaderText = "Cantidad";
            this.ColCantidad.MinimumWidth = 8;
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.Width = 150;
            // 
            // ColStock
            // 
            this.ColStock.HeaderText = "Stock";
            this.ColStock.MinimumWidth = 8;
            this.ColStock.Name = "ColStock";
            this.ColStock.Width = 150;
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
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(966, 694);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(117, 45);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(818, 694);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 45);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGenerarAlerta
            // 
            this.btnGenerarAlerta.Location = new System.Drawing.Point(652, 694);
            this.btnGenerarAlerta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerarAlerta.Name = "btnGenerarAlerta";
            this.btnGenerarAlerta.Size = new System.Drawing.Size(122, 57);
            this.btnGenerarAlerta.TabIndex = 14;
            this.btnGenerarAlerta.Text = "Generar alerta";
            this.btnGenerarAlerta.UseVisualStyleBackColor = true;
            // 
            // ABMProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 791);
            this.Controls.Add(this.btnGenerarAlerta);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBoxCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.cboxSubcategoria);
            this.Controls.Add(this.lblSubcategoria);
            this.Controls.Add(this.cboxCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtBoxNombreProducto);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.btnAltaProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ABMProductos";
            this.Text = "Administrar Productos";
            this.Load += new System.EventHandler(this.ABMProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAltaProducto;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.TextBox txtBoxNombreProducto;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboxCategoria;
        private System.Windows.Forms.Label lblSubcategoria;
        private System.Windows.Forms.ComboBox cboxSubcategoria;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtBoxCantidad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSubcategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStock;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColSeleccionar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGenerarAlerta;
    }
}