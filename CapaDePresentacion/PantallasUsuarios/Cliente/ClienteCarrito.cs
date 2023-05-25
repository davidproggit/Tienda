﻿using CapaComun.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuarios.Cliente
{
    public partial class ClienteCarrito : Form
    {
        public ClienteCarrito()
        {
            InitializeComponent();
        }


        #region "Cargar datos"

        public List<Datos> Valores { get; set; }
        private List<string> _idLista = new List<string>();

        private void ClienteCarrito_Load(object sender, EventArgs e)
        {
            Rellenar(Valores);
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
                    grillaProductos.Rows[posicion].Cells[2].Value = valor.precio;
                    grillaProductos.Rows[posicion].Cells[3].Value = valor.cantidad;
                    _idLista.Add(valor.id.ToString());
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