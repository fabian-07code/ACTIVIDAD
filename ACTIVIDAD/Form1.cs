namespace ACTIVIDAD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void registarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frRegistraUsuario objfrRegistraUsuario = new frRegistraUsuario();
            objfrRegistraUsuario.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frConsultaUsuario objCconsultarUsuario = new frConsultaUsuario();
            objCconsultarUsuario.ShowDialog();
        }

        private void registarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frRegistraSala objRegistarSala = new frRegistraSala();
            objRegistarSala.ShowDialog();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frConsultaSalas objCconsultarSalas = new frConsultaSalas();
            objCconsultarSalas.ShowDialog();
        }

        private void registarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frRegistraReservacion objRegistarReservacion = new frRegistraReservacion();
            objRegistarReservacion.ShowDialog();
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frConsultaReservacion objConsultaReservacion = new frConsultaReservacion();
            objConsultaReservacion.ShowDialog();
        }
    }
}
