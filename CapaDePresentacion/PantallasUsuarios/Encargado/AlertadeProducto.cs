using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaComun.Cache;
using CapaDeNegocio;

namespace CapaDePresentacion
{
    public partial class AlertadeProducto : Form
    {
        private bool _sinProducto = true;

        public AlertadeProducto()
        {
            InitializeComponent();
        }

        #region "Cargar datos"

        public List<Datos> Valores { get; set; }

        private void AlertadeProducto_Load(object sender, EventArgs e)
        {
            Rellenar(Valores);
        }

        public void Rellenar(List<Datos> valores)
        {
            foreach (Datos valor in valores)
            {
                int posicion = grillaProductos.Rows.Add();

                try
                {
                    grillaProductos.Rows[posicion].Cells[0].Value = valor.id;
                    grillaProductos.Rows[posicion].Cells[1].Value = valor.nombre;
                    _sinProducto = false;
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Error: valor fuera del rango");
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Error: operacion no valida");
                }

            }
        }

        #endregion

        #region "Botones"

        private void btnGuardarAlerta_Click(object sender, EventArgs e)
        {
            if (!_sinProducto)
                CambiarMensajeCantidad(Valores);
            else
                MessageBox.Show("Error: debe haber al menos 1 producto cargado");
        }

        private void btnAlertCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region "Metodos de los botones"

        private void CambiarMensajeCantidad(List<Datos> valores)
        {
            if (txtMensaje.Text != "" && txtCantidadMinima.Text != "")
            {
                Productos productos = new Productos();

                foreach (Datos valor in valores)
                    productos.ModificarAlerta(valor.id, txtMensaje.Text, txtCantidadMinima.Text);

                MessageBox.Show("Alerta guardada");
            }
            else
                MessageBox.Show("Error: los campos no pueden estar vacios");
        }

        #endregion

    }
}
