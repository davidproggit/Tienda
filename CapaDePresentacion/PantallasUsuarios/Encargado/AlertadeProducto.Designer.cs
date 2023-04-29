
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
            this.lblGenerarAlerta = new System.Windows.Forms.Label();
            this.lblcantidadproducto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblMen = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColAlerNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAlerCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAlerSubcategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAlerStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAlerSeleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnGuardarAlerta = new System.Windows.Forms.Button();
            this.btnAlertCancelar = new System.Windows.Forms.Button();
            this.btnAlerQuitarProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGenerarAlerta
            // 
            this.lblGenerarAlerta.AutoSize = true;
            this.lblGenerarAlerta.Location = new System.Drawing.Point(498, 58);
            this.lblGenerarAlerta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenerarAlerta.Name = "lblGenerarAlerta";
            this.lblGenerarAlerta.Size = new System.Drawing.Size(148, 20);
            this.lblGenerarAlerta.TabIndex = 0;
            this.lblGenerarAlerta.Text = "Alerta de productos";
            // 
            // lblcantidadproducto
            // 
            this.lblcantidadproducto.AutoSize = true;
            this.lblcantidadproducto.Location = new System.Drawing.Point(66, 455);
            this.lblcantidadproducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcantidadproducto.Name = "lblcantidadproducto";
            this.lblcantidadproducto.Size = new System.Drawing.Size(174, 20);
            this.lblcantidadproducto.TabIndex = 1;
            this.lblcantidadproducto.Text = "Cantidad de productos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(703, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "En esta pantalla se configurara el alerta dependiendo la cantidad de productos qu" +
    "e esten en stock";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(250, 451);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 26);
            this.textBox1.TabIndex = 3;
            // 
            // lblMen
            // 
            this.lblMen.AutoSize = true;
            this.lblMen.Location = new System.Drawing.Point(166, 511);
            this.lblMen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMen.Name = "lblMen";
            this.lblMen.Size = new System.Drawing.Size(73, 20);
            this.lblMen.TabIndex = 4;
            this.lblMen.Text = "Mensaje:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(250, 506);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 26);
            this.textBox2.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColAlerNombre,
            this.ColAlerCategoria,
            this.ColAlerSubcategoria,
            this.ColAlerStock,
            this.ColAlerSeleccionar});
            this.dataGridView1.Location = new System.Drawing.Point(171, 229);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(812, 106);
            this.dataGridView1.TabIndex = 6;
            // 
            // ColAlerNombre
            // 
            this.ColAlerNombre.HeaderText = "Nombre";
            this.ColAlerNombre.MinimumWidth = 8;
            this.ColAlerNombre.Name = "ColAlerNombre";
            this.ColAlerNombre.Width = 150;
            // 
            // ColAlerCategoria
            // 
            this.ColAlerCategoria.HeaderText = "Categoria";
            this.ColAlerCategoria.MinimumWidth = 8;
            this.ColAlerCategoria.Name = "ColAlerCategoria";
            this.ColAlerCategoria.Width = 150;
            // 
            // ColAlerSubcategoria
            // 
            this.ColAlerSubcategoria.HeaderText = "Subcategoria";
            this.ColAlerSubcategoria.MinimumWidth = 8;
            this.ColAlerSubcategoria.Name = "ColAlerSubcategoria";
            this.ColAlerSubcategoria.Width = 150;
            // 
            // ColAlerStock
            // 
            this.ColAlerStock.HeaderText = "Stock";
            this.ColAlerStock.MinimumWidth = 8;
            this.ColAlerStock.Name = "ColAlerStock";
            this.ColAlerStock.Width = 150;
            // 
            // ColAlerSeleccionar
            // 
            this.ColAlerSeleccionar.HeaderText = "Seleccionar";
            this.ColAlerSeleccionar.MinimumWidth = 8;
            this.ColAlerSeleccionar.Name = "ColAlerSeleccionar";
            this.ColAlerSeleccionar.Width = 150;
            // 
            // btnGuardarAlerta
            // 
            this.btnGuardarAlerta.Location = new System.Drawing.Point(1016, 614);
            this.btnGuardarAlerta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarAlerta.Name = "btnGuardarAlerta";
            this.btnGuardarAlerta.Size = new System.Drawing.Size(112, 35);
            this.btnGuardarAlerta.TabIndex = 7;
            this.btnGuardarAlerta.Text = "Guardar";
            this.btnGuardarAlerta.UseVisualStyleBackColor = true;
            // 
            // btnAlertCancelar
            // 
            this.btnAlertCancelar.Location = new System.Drawing.Point(870, 614);
            this.btnAlertCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAlertCancelar.Name = "btnAlertCancelar";
            this.btnAlertCancelar.Size = new System.Drawing.Size(112, 35);
            this.btnAlertCancelar.TabIndex = 8;
            this.btnAlertCancelar.Text = "Cancelar";
            this.btnAlertCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAlerQuitarProducto
            // 
            this.btnAlerQuitarProducto.Location = new System.Drawing.Point(662, 614);
            this.btnAlerQuitarProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAlerQuitarProducto.Name = "btnAlerQuitarProducto";
            this.btnAlerQuitarProducto.Size = new System.Drawing.Size(174, 35);
            this.btnAlerQuitarProducto.TabIndex = 9;
            this.btnAlerQuitarProducto.Text = "Quitar producto";
            this.btnAlerQuitarProducto.UseVisualStyleBackColor = true;
            // 
            // AlertadeProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnAlerQuitarProducto);
            this.Controls.Add(this.btnAlertCancelar);
            this.Controls.Add(this.btnGuardarAlerta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblMen);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcantidadproducto);
            this.Controls.Add(this.lblGenerarAlerta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AlertadeProducto";
            this.Text = "Alerta de Producto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGenerarAlerta;
        private System.Windows.Forms.Label lblcantidadproducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblMen;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAlerNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAlerCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAlerSubcategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAlerStock;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColAlerSeleccionar;
        private System.Windows.Forms.Button btnGuardarAlerta;
        private System.Windows.Forms.Button btnAlertCancelar;
        private System.Windows.Forms.Button btnAlerQuitarProducto;
    }
}