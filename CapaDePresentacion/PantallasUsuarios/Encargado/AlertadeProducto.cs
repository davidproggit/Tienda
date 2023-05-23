﻿using System;
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

        private void AlertadeProducto_Load(object sender, EventArgs e)
        {
            Rellenar(Valores);
        }

        public List<Datos> Valores { get; set; }
        private List<string> _idLista = new List<string>();

        public void Rellenar(List<Datos> valores)
        {
            foreach (Datos valor in valores)
            {
                int posicion = grillaProductos.Rows.Add();

                try 
                {
                    grillaProductos.Rows[posicion].Cells[0].Value = valor.id;
                    grillaProductos.Rows[posicion].Cells[1].Value = valor.nombre;
                    _idLista.Add(valor.id.ToString());
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

        private void btnGuardarAlerta_Click(object sender, EventArgs e)
        {
            if (!_sinProducto)
                CambiarMensajeCantidad(Valores);
            else
                MessageBox.Show("Error: debe haber al menos 1 producto cargado");
        }

        private void CambiarMensajeCantidad(List<Datos> valores)
        {
            if (txtMensaje.Text != "" && txtCantidadMinima.Text != "")
            {
                Productos productos = new Productos();

                foreach (string id in _idLista)
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