namespace CapaDePresentacion
{
    partial class InterfazProducto
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grillaProductos = new System.Windows.Forms.DataGridView();
            this.textoNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.textoDescripcion = new System.Windows.Forms.TextBox();
            this.labelMarca = new System.Windows.Forms.Label();
            this.textoMarca = new System.Windows.Forms.TextBox();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.textoPrecio = new System.Windows.Forms.TextBox();
            this.labelStock = new System.Windows.Forms.Label();
            this.textoStock = new System.Windows.Forms.TextBox();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.botonEditar = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaProductos
            // 
            this.grillaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaProductos.Location = new System.Drawing.Point(68, 65);
            this.grillaProductos.Name = "grillaProductos";
            this.grillaProductos.RowHeadersWidth = 62;
            this.grillaProductos.RowTemplate.Height = 28;
            this.grillaProductos.Size = new System.Drawing.Size(840, 427);
            this.grillaProductos.TabIndex = 0;
            // 
            // textoNombre
            // 
            this.textoNombre.Location = new System.Drawing.Point(1066, 65);
            this.textoNombre.Name = "textoNombre";
            this.textoNombre.Size = new System.Drawing.Size(163, 26);
            this.textoNombre.TabIndex = 1;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(954, 68);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(65, 20);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(954, 123);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(92, 20);
            this.labelDescripcion.TabIndex = 4;
            this.labelDescripcion.Text = "Descripcion";
            // 
            // textoDescripcion
            // 
            this.textoDescripcion.Location = new System.Drawing.Point(1066, 120);
            this.textoDescripcion.Name = "textoDescripcion";
            this.textoDescripcion.Size = new System.Drawing.Size(163, 26);
            this.textoDescripcion.TabIndex = 3;
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(954, 189);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(53, 20);
            this.labelMarca.TabIndex = 6;
            this.labelMarca.Text = "Marca";
            // 
            // textoMarca
            // 
            this.textoMarca.Location = new System.Drawing.Point(1066, 186);
            this.textoMarca.Name = "textoMarca";
            this.textoMarca.Size = new System.Drawing.Size(163, 26);
            this.textoMarca.TabIndex = 5;
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(954, 257);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(53, 20);
            this.labelPrecio.TabIndex = 8;
            this.labelPrecio.Text = "Precio";
            // 
            // textoPrecio
            // 
            this.textoPrecio.Location = new System.Drawing.Point(1066, 254);
            this.textoPrecio.Name = "textoPrecio";
            this.textoPrecio.Size = new System.Drawing.Size(163, 26);
            this.textoPrecio.TabIndex = 7;
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Location = new System.Drawing.Point(954, 318);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(50, 20);
            this.labelStock.TabIndex = 10;
            this.labelStock.Text = "Stock";
            // 
            // textoStock
            // 
            this.textoStock.Location = new System.Drawing.Point(1066, 315);
            this.textoStock.Name = "textoStock";
            this.textoStock.Size = new System.Drawing.Size(163, 26);
            this.textoStock.TabIndex = 9;
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(1024, 387);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(140, 71);
            this.botonGuardar.TabIndex = 11;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // botonEditar
            // 
            this.botonEditar.Location = new System.Drawing.Point(115, 532);
            this.botonEditar.Name = "botonEditar";
            this.botonEditar.Size = new System.Drawing.Size(140, 71);
            this.botonEditar.TabIndex = 12;
            this.botonEditar.Text = "Editar";
            this.botonEditar.UseVisualStyleBackColor = true;
            this.botonEditar.Click += new System.EventHandler(this.botonEditar_Click);
            // 
            // botonEliminar
            // 
            this.botonEliminar.Location = new System.Drawing.Point(311, 532);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(140, 71);
            this.botonEliminar.TabIndex = 13;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // InterfazProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 630);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonEditar);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.textoStock);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.textoPrecio);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.textoMarca);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.textoDescripcion);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textoNombre);
            this.Controls.Add(this.grillaProductos);
            this.Name = "InterfazProducto";
            this.Text = "InterfazProducto";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaProductos;
        private System.Windows.Forms.TextBox textoNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TextBox textoDescripcion;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.TextBox textoMarca;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.TextBox textoPrecio;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.TextBox textoStock;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.Button botonEditar;
        private System.Windows.Forms.Button botonEliminar;
    }
}

