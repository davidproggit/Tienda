using CapaComun;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuarios.UsuarioCliente
{
    public partial class ClienteCarrito : Form
    {
        #region "Constructor"
        
        public ClienteCarrito()
        {
            InitializeComponent();
        }

        #endregion

        #region "Cargar datos"

        public List<DatosAlerta> valores { get; set; }

        private void ClienteCarrito_Load(object sender, EventArgs e)
        {
            //Rellenar(Valores);
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
                    grillaProductos.Rows[posicion].Cells[2].Value = valor.precio;
                    grillaProductos.Rows[posicion].Cells[3].Value = valor.cantidad;
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

    }
}
