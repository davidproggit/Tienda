using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApp2;
using static ConsoleApp2.Objetos;

namespace WindowsFormsApp2
{
    public partial class Interfaz : Form
    {

        public Interfaz()
        {
            InitializeComponent();
            NombreCategoria.Text = string.Empty;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void puertasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imagen.Load(Puerta.ActualizarImagen());
            NombreCategoria.Text = Puerta.ActualizarNombre();
        }

        private void mesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imagen.Load(Mesa.ActualizarImagen());
            NombreCategoria.Text = Mesa.ActualizarNombre();
        }

        private void sillasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imagen.Load(Silla.ActualizarImagen());
            NombreCategoria.Text = Silla.ActualizarNombre();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
