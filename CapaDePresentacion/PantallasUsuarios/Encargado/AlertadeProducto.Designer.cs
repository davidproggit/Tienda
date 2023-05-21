
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
            this.btnGuardarAlerta = new System.Windows.Forms.Button();
            this.btnAlertCancelar = new System.Windows.Forms.Button();
            this.btnAlerQuitarProducto = new System.Windows.Forms.Button();
            this.ColAlerNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAlerMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAlePrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAlerStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAlerSeleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGenerarAlerta
            // 
            this.lblGenerarAlerta.AutoSize = true;
            this.lblGenerarAlerta.Location = new System.Drawing.Point(332, 38);
            this.lblGenerarAlerta.Name = "lblGenerarAlerta";
            this.lblGenerarAlerta.Size = new System.Drawing.Size(99, 13);
            this.lblGenerarAlerta.TabIndex = 0;
            this.lblGenerarAlerta.Text = "Alerta de productos";
            // 
            // lblcantidadproducto
            // 
            this.lblcantidadproducto.AutoSize = true;
            this.lblcantidadproducto.Location = new System.Drawing.Point(44, 296);
            this.lblcantidadproducto.Name = "lblcantidadproducto";
            this.lblcantidadproducto.Size = new System.Drawing.Size(117, 13);
            this.lblcantidadproducto.TabIndex = 1;
            this.lblcantidadproducto.Text = "Cantidad de productos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "En esta pantalla se configurara el alerta dependiendo la cantidad de productos qu" +
    "e esten en stock";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 293);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lblMen
            // 
            this.lblMen.AutoSize = true;
            this.lblMen.Location = new System.Drawing.Point(111, 332);
            this.lblMen.Name = "lblMen";
            this.lblMen.Size = new System.Drawing.Size(50, 13);
            this.lblMen.TabIndex = 4;
            this.lblMen.Text = "Mensaje:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(167, 329);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(143, 20);
            this.textBox2.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColAlerNombre,
            this.ColAlerMarca,
            this.ColAlePrecio,
            this.ColAlerStock,
            this.ColDescripcion,
            this.ColAlerSeleccionar});
            this.dataGridView1.Location = new System.Drawing.Point(129, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(557, 63);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnGuardarAlerta
            // 
            this.btnGuardarAlerta.Location = new System.Drawing.Point(677, 399);
            this.btnGuardarAlerta.Name = "btnGuardarAlerta";
            this.btnGuardarAlerta.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarAlerta.TabIndex = 7;
            this.btnGuardarAlerta.Text = "Guardar";
            this.btnGuardarAlerta.UseVisualStyleBackColor = true;
            // 
            // btnAlertCancelar
            // 
            this.btnAlertCancelar.Location = new System.Drawing.Point(580, 399);
            this.btnAlertCancelar.Name = "btnAlertCancelar";
            this.btnAlertCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnAlertCancelar.TabIndex = 8;
            this.btnAlertCancelar.Text = "Cancelar";
            this.btnAlertCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAlerQuitarProducto
            // 
            this.btnAlerQuitarProducto.Location = new System.Drawing.Point(441, 399);
            this.btnAlerQuitarProducto.Name = "btnAlerQuitarProducto";
            this.btnAlerQuitarProducto.Size = new System.Drawing.Size(116, 23);
            this.btnAlerQuitarProducto.TabIndex = 9;
            this.btnAlerQuitarProducto.Text = "Quitar producto";
            this.btnAlerQuitarProducto.UseVisualStyleBackColor = true;
            // 
            // ColAlerNombre
            // 
            this.ColAlerNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColAlerNombre.HeaderText = "Nombre";
            this.ColAlerNombre.MinimumWidth = 8;
            this.ColAlerNombre.Name = "ColAlerNombre";
            this.ColAlerNombre.Width = 69;
            // 
            // ColAlerMarca
            // 
            this.ColAlerMarca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColAlerMarca.HeaderText = "Marca";
            this.ColAlerMarca.MinimumWidth = 8;
            this.ColAlerMarca.Name = "ColAlerMarca";
            this.ColAlerMarca.Width = 62;
            // 
            // ColAlePrecio
            // 
            this.ColAlePrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColAlePrecio.HeaderText = "Precio";
            this.ColAlePrecio.MinimumWidth = 8;
            this.ColAlePrecio.Name = "ColAlePrecio";
            this.ColAlePrecio.Width = 62;
            // 
            // ColAlerStock
            // 
            this.ColAlerStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColAlerStock.HeaderText = "Stock";
            this.ColAlerStock.MinimumWidth = 8;
            this.ColAlerStock.Name = "ColAlerStock";
            this.ColAlerStock.Width = 60;
            // 
            // ColDescripcion
            // 
            this.ColDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColDescripcion.HeaderText = "Descripcion ";
            this.ColDescripcion.Name = "ColDescripcion";
            this.ColDescripcion.Width = 91;
            // 
            // ColAlerSeleccionar
            // 
            this.ColAlerSeleccionar.HeaderText = "Seleccionar";
            this.ColAlerSeleccionar.MinimumWidth = 8;
            this.ColAlerSeleccionar.Name = "ColAlerSeleccionar";
            this.ColAlerSeleccionar.Width = 150;
            // 
            // AlertadeProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.Button btnGuardarAlerta;
        private System.Windows.Forms.Button btnAlertCancelar;
        private System.Windows.Forms.Button btnAlerQuitarProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAlerNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAlerMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAlePrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAlerStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescripcion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColAlerSeleccionar;
    }
}