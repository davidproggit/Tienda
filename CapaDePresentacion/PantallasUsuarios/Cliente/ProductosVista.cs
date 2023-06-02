using CapaDeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaComun;

namespace WindowsFormsApp1
{
    public partial class ProductosVista : Form
    {
        private List<FormatoProductos> _valores = new List<FormatoProductos>();

        public ProductosVista()
        {
            InitializeComponent();
            Llenar();
        }

        private void Llenar()
        {
            Productos productos = new Productos();
            _valores = productos.Rellenar();

            foreach (FormatoProductos datos in _valores)
            {
                ProductoPrevisualizacion productoPrevisualizacion = new ProductoPrevisualizacion();

                productoPrevisualizacion.id = datos.id;
                productoPrevisualizacion.nombre = datos.nombre;
                productoPrevisualizacion.descripcion = datos.descripcion;
                productoPrevisualizacion.marca = datos.marca;
                productoPrevisualizacion.precio = "$" + datos.precio;
                productoPrevisualizacion.cantidad = datos.cantidad.ToString();

                contenedorProductos.Controls.Add(productoPrevisualizacion);
            }
        }

    }
}
