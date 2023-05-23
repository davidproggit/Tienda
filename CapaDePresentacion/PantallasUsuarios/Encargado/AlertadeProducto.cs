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
        private bool sinProducto = true;

        public AlertadeProducto()
        {
            InitializeComponent();
        }

        private void AlertadeProducto_Load(object sender, EventArgs e)
        {
            Rellenar(Valores);
        }

        public List<Datos> Valores { get; set; }
        List<string> idLista = new List<string>();

        public void Rellenar(List<Datos> valores)
        {
            foreach (Datos valor in valores)
            {
                int posicion = grilla.Rows.Add();

                try 
                {
                    grilla.Rows[posicion].Cells[0].Value = valor.id;
                    grilla.Rows[posicion].Cells[1].Value = valor.nombre;
                    idLista.Add(valor.id.ToString());
                    sinProducto = false;
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

        private void btnGuardarAlerta_Click(object sender, EventArgs e)
        {
            if (!sinProducto)
                CambiarMensajeCantidad(Valores);
            else
                MessageBox.Show("Error: debe haber al menos 1 producto cargado");
        }

        private void CambiarMensajeCantidad(List<Datos> valores)
        {
            if (txtMensaje.Text != "" && txtCantidadMinima.Text != "")
            {
                Productos productos = new Productos();

                foreach (string id in idLista)
                {
                    productos.ModificarAlerta(id, txtMensaje.Text, int.Parse(txtCantidadMinima.Text));
                }

                MessageBox.Show("Alerta guardada");
            }
            else
            {
                MessageBox.Show("Error: los campos no pueden estar vacios");
            }

        }

        private void btnAlertCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
