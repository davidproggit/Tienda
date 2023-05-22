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

namespace CapaDePresentacion
{
    public partial class AlertadeProducto : Form
    {
        public AlertadeProducto()
        {
            InitializeComponent();
        }

        private void AlertadeProducto_Load(object sender, EventArgs e)
        {
            Rellenar(Valores);
        }

        public List<Datos> Valores { get; set; }

        public void Rellenar(List<Datos> valores)
        {
            if (valores != null)
            {
                foreach (Datos valor in valores)
                {
                    int posicion = grilla.Rows.Add();

                    grilla.Rows[posicion].Cells[0].Value = valor.id;
                    grilla.Rows[posicion].Cells[1].Value = valor.nombre;
                }
            }
        }

    }
}
