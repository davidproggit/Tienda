using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaComun;
using CapaDeEntidades;

namespace CapaDePresentacion
{
    public partial class AlertadeProducto : Form
    {
        public List<DatosAlerta> valores { get; set; }

        private bool _sinProducto = true;

        public AlertadeProducto()
        {
            InitializeComponent();
        }

        #region "Cargar datos"

        private void AlertadeProducto_Load(object sender, EventArgs e)
        {
            Rellenar(valores);
        }

        public void Rellenar(List<DatosAlerta> valores)
        {
            foreach (DatosAlerta valor in valores)
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
                CambiarMensajeCantidad(valores);
            else
                MessageBox.Show("Error: debe haber al menos 1 producto cargado");
        }

        private void btnAlertCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region "Metodos de los botones"

        private void CambiarMensajeCantidad(List<DatosAlerta> valores)
        {
            Proveedor proveedor = new Proveedor();

            if (rTBoxMensajeAlerta.Text != "" && txtCantidadMinima.Text != "")
            {
                foreach (DatosAlerta valor in valores)
                    proveedor.ModificarAlerta(valor.id, rTBoxMensajeAlerta.Text, txtCantidadMinima.Text);

                MessageBox.Show("Alerta guardada");
            }
            else
                MessageBox.Show("Error: los campos no pueden estar vacios");
        }

        #endregion

    }
}
