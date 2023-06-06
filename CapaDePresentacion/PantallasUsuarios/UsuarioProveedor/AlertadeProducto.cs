using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaComun.Cache;
using CapaDeEntidades;

namespace CapaDePresentacion
{
    public partial class AlertadeProducto : Form
    {
        #region "Objetos"

        Proveedor _proveedor = new Proveedor();
        public List<Datos> valores { get; set; }

        #endregion

        #region "Atributo"

        private bool _sinProducto = true;

        #endregion

        #region "Constructor"

        public AlertadeProducto()
        {
            InitializeComponent();
        }

        #endregion

        #region "Cargar datos"

        private void AlertadeProducto_Load(object sender, EventArgs e)
        {
            Rellenar(valores);
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

        private void CambiarMensajeCantidad(List<Datos> valores)
        {
            if (rTBoxMensajeAlerta.Text != "" && txtCantidadMinima.Text != "")
            {
                foreach (Datos valor in valores)
                    _proveedor.ModificarAlerta(valor.id, rTBoxMensajeAlerta.Text, txtCantidadMinima.Text);

                MessageBox.Show("Alerta guardada");
            }
            else
                MessageBox.Show("Error: los campos no pueden estar vacios");
        }

        #endregion

    }
}
