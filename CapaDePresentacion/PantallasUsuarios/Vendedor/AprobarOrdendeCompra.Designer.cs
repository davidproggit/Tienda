
namespace CapaDePresentacion.PantallasUsuarios.Vendedor
{
    partial class AprobarOrdendeCompra
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblAprobarOC = new System.Windows.Forms.Label();
            this.btnAprobar = new System.Windows.Forms.Button();
            this.btnRechazar = new System.Windows.Forms.Button();
            this.ColNomCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNomProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecioProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSeleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNomCliente,
            this.ColApellido,
            this.ColDNI,
            this.ColEmail,
            this.ColNomProd,
            this.ColDescProducto,
            this.ColMarca,
            this.ColPrecioProd,
            this.ColStock,
            this.ColSeleccionar});
            this.dataGridView1.Location = new System.Drawing.Point(1, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(797, 110);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblAprobarOC
            // 
            this.lblAprobarOC.AutoSize = true;
            this.lblAprobarOC.Location = new System.Drawing.Point(316, 54);
            this.lblAprobarOC.Name = "lblAprobarOC";
            this.lblAprobarOC.Size = new System.Drawing.Size(152, 13);
            this.lblAprobarOC.TabIndex = 1;
            this.lblAprobarOC.Text = "Gestión de ordenes de compra";
            this.lblAprobarOC.UseMnemonic = false;
            // 
            // btnAprobar
            // 
            this.btnAprobar.Location = new System.Drawing.Point(580, 387);
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Size = new System.Drawing.Size(75, 23);
            this.btnAprobar.TabIndex = 2;
            this.btnAprobar.Text = "Aprobar";
            this.btnAprobar.UseVisualStyleBackColor = true;
            // 
            // btnRechazar
            // 
            this.btnRechazar.Location = new System.Drawing.Point(678, 387);
            this.btnRechazar.Name = "btnRechazar";
            this.btnRechazar.Size = new System.Drawing.Size(75, 23);
            this.btnRechazar.TabIndex = 3;
            this.btnRechazar.Text = "Rechazar";
            this.btnRechazar.UseVisualStyleBackColor = true;
            // 
            // ColNomCliente
            // 
            this.ColNomCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColNomCliente.HeaderText = "Nombre Cliente";
            this.ColNomCliente.Name = "ColNomCliente";
            this.ColNomCliente.Width = 96;
            // 
            // ColApellido
            // 
            this.ColApellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColApellido.HeaderText = "Apellido";
            this.ColApellido.Name = "ColApellido";
            this.ColApellido.Width = 69;
            // 
            // ColDNI
            // 
            this.ColDNI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColDNI.HeaderText = "DNI";
            this.ColDNI.Name = "ColDNI";
            this.ColDNI.Width = 51;
            // 
            // ColEmail
            // 
            this.ColEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColEmail.HeaderText = "Email";
            this.ColEmail.Name = "ColEmail";
            this.ColEmail.Width = 57;
            // 
            // ColNomProd
            // 
            this.ColNomProd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColNomProd.HeaderText = "Nombre Producto";
            this.ColNomProd.Name = "ColNomProd";
            this.ColNomProd.Width = 105;
            // 
            // ColDescProducto
            // 
            this.ColDescProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColDescProducto.HeaderText = "Descripcion";
            this.ColDescProducto.Name = "ColDescProducto";
            this.ColDescProducto.Width = 88;
            // 
            // ColMarca
            // 
            this.ColMarca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColMarca.HeaderText = "Marca";
            this.ColMarca.Name = "ColMarca";
            this.ColMarca.Width = 62;
            // 
            // ColPrecioProd
            // 
            this.ColPrecioProd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColPrecioProd.HeaderText = "Precio Unitario";
            this.ColPrecioProd.Name = "ColPrecioProd";
            this.ColPrecioProd.Width = 93;
            // 
            // ColStock
            // 
            this.ColStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColStock.HeaderText = "Stock";
            this.ColStock.Name = "ColStock";
            this.ColStock.Width = 60;
            // 
            // ColSeleccionar
            // 
            this.ColSeleccionar.HeaderText = "Seleccionar";
            this.ColSeleccionar.Name = "ColSeleccionar";
            // 
            // AprobarOrdendeCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRechazar);
            this.Controls.Add(this.btnAprobar);
            this.Controls.Add(this.lblAprobarOC);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AprobarOrdendeCompra";
            this.Text = "AprobarOrdendeCompra";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNomCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNomProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecioProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStock;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColSeleccionar;
        private System.Windows.Forms.Label lblAprobarOC;
        private System.Windows.Forms.Button btnAprobar;
        private System.Windows.Forms.Button btnRechazar;
    }
}