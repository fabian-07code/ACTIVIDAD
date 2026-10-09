using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ACTIVIDAD.Data;
using ACTIVIDAD.Modelos;

namespace ACTIVIDAD
{
    public partial class frConsultaSalas : Form
    {
        public frConsultaSalas()
        {
            InitializeComponent();
        }

        private void frConsultaSalas_Load(object sender, EventArgs e)
        {
            DatosSala datosSalas = new  DatosSala();
            List<Salas> salas = datosSalas.ObtenerSalas();

            dvgSalas.DataSource = salas;
        }
    }
}
