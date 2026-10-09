using ACTIVIDAD.Data;
using ACTIVIDAD.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ACTIVIDAD
{
    public partial class frRegistraSala : Form
    {
        public frRegistraSala()
        {
            InitializeComponent();
        }

        private void btnGuardarS_Click(object sender, EventArgs e)
        {
            DatosSala datosSala = new DatosSala();

            Salas salas = new Salas
            {
                NombreSala = txtNombreSala.Text,
                Capacidad = Convert.ToInt32(txtCapacidad.Text)
            };

            datosSala.GuardarSala(salas);

            LimparCampos();

            MessageBox.Show("Sala guardada correctamente.");

        }

        private void LimparCampos()
        {
            txtNombreSala.Text = string.Empty;
            txtCapacidad.Text = string.Empty;
        }
    }
}
