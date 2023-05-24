
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.btnCompraProducto = new System.Windows.Forms.Button();
            this.btnQuitarProducto = new System.Windows.Forms.Button();
            this.grillaProductos = new System.Windows.Forms.DataGridView();
            this.ColSeleccionarProducto = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(531, 86);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(220, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Comprar productos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(62, 163);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(107, 29);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.UseWaitCursor = true;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(169, 160);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(834, 35);
            this.txtBusqueda.TabIndex = 2;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.Location = new System.Drawing.Point(1017, 155);
            this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(132, 50);
            this.btnBuscarProducto.TabIndex = 3;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            // 
            // btnCompraProducto
            // 
            this.btnCompraProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompraProducto.Location = new System.Drawing.Point(1017, 600);
            this.btnCompraProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCompraProducto.Name = "btnCompraProducto";
            this.btnCompraProducto.Size = new System.Drawing.Size(132, 51);
            this.btnCompraProducto.TabIndex = 10;
            this.btnCompraProducto.Text = "Comprar";
            this.btnCompraProducto.UseVisualStyleBackColor = true;
            // 
            // btnQuitarProducto
            // 
            this.btnQuitarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarProducto.Location = new System.Drawing.Point(824, 600);
            this.btnQuitarProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQuitarProducto.Name = "btnQuitarProducto";
            this.btnQuitarProducto.Size = new System.Drawing.Size(130, 51);
            this.btnQuitarProducto.TabIndex = 11;
            this.btnQuitarProducto.Text = "Quitar";
            this.btnQuitarProducto.UseVisualStyleBackColor = true;
            // 
            // grillaProductos
            // 
            this.grillaProductos.AllowUserToAddRows = false;
            this.grillaProductos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grillaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSeleccionarProducto});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grillaProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.grillaProductos.Location = new System.Drawing.Point(67, 225);
            this.grillaProductos.Name = "grillaProductos";
            this.grillaProductos.RowHeadersVisible = false;
            this.grillaProductos.RowHeadersWidth = 62;
            this.grillaProductos.RowTemplate.Height = 28;
            this.grillaProductos.Size = new System.Drawing.Size(1082, 265);
            this.grillaProductos.TabIndex = 12;
            // 
            // ColSeleccionarProducto
            // 
            this.ColSeleccionarProducto.HeaderText = "Agregar";
            this.ColSeleccionarProducto.MinimumWidth = 8;
            this.ColSeleccionarProducto.Name = "ColSeleccionarProducto";
            this.ColSeleccionarProducto.Width = 150;
            // 
            // ABMCompraProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.grillaProductos);
            this.Controls.Add(this.btnQuitarProducto);
            this.Controls.Add(this.btnCompraProducto);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ABMCompraProductos";
            this.Text = "Compra de Productos";
            this.Load += new System.EventHandler(this.ABMCompraProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Button btnCompraProducto;
        private System.Windows.Forms.Button btnQuitarProducto;
        private System.Windows.Forms.DataGridView grillaProductos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColSeleccionarProducto;
    }
}