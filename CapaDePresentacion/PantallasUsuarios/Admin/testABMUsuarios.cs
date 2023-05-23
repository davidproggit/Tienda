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

namespace CapaDePresentacion
{
    public partial class testABMEmpleados : Form
    {
        public testABMEmpleados()
        {
            InitializeComponent();
        }

        private void lblNombreCliente_Click(object sender, EventArgs e)
        {

        }

        private void testABMEmpleados_Load(object sender, EventArgs e)
        {
            CargarListaUsuarios();
        }

        private void CargarListaUsuarios()
        {
            ModeloUsuario objeto = new ModeloUsuario();
            dataGridView1.DataSource = objeto.CargarUsuarios();
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            GuardarNuevoUsuario();
        }
       
        private void GuardarNuevoUsuario()
        {
            ModeloUsuario objetoCapaNegocio = new ModeloUsuario();

             objetoCapaNegocio.InsertarNuevoUsuario(txtUsuario.Text, txtClave.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, comboCargo.Text, txtDNI.Text, txtCuil.Text);
        }

    }
}
