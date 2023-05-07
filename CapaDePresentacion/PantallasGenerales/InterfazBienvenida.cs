using CapaComun.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasGenerales
{
    public partial class InterfazBienvenida : Form
    {
        public InterfazBienvenida()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;

            BarraProgreso.Value++;

            if (BarraProgreso.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;

            if (this.Opacity <= 0)
            {
                timer2.Stop();
                this.Close();
            }
        }

        private void InterfazBienvenida_Load(object sender, EventArgs e)
        {
            etiquetaUsuario.Text = CacheSesionUsuario.Nombre + " " + CacheSesionUsuario.Apellido;
            this.Opacity = 0.0;
            timer1.Start();
        }
    }
}
