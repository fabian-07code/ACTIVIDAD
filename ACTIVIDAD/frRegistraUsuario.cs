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
    public partial class frRegistraUsuario : Form
    {
        public frRegistraUsuario()
        {
            InitializeComponent();
        }

        private void btnGuardarU_Click(object sender, EventArgs e)
        {
            DatosUsuario datosUsuario = new DatosUsuario();

            Usuarios usuarios = new Usuarios
            {
                Nombre = txtNombre.Text,
                Departamento = txtDepartamento.Text,
                Telefono = Label3.Text
            };

            datosUsuario.GuardarUsuario(usuarios);
            
            limparCampos();

            MessageBox.Show("Usuario guardado correctamente.");

            
        }
        private void limparCampos()
        {
            txtNombre.Text = string.Empty;
            txtDepartamento.Text = string.Empty;
            Label3.Text = string.Empty;
        }
    }
}
