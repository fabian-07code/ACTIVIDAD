using ACTIVIDAD.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ACTIVIDAD.Modelos;

namespace ACTIVIDAD
{
    public partial class frConsultaUsuario : Form
    {
        public frConsultaUsuario()
        {
            InitializeComponent();
        }

        private void frConsultaUsuario_Load(object sender, EventArgs e)
        {
            DatosUsuario datosUsuario = new DatosUsuario();
            List<Usuarios> usuarios = datosUsuario.ObtenerUsuarios();

            dgvUsuarios.DataSource = usuarios;
        }
    }
}
