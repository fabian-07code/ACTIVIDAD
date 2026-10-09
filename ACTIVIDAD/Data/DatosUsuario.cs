using ACTIVIDAD.Modelos;

namespace ACTIVIDAD.Data
{
    public class DatosUsuario
    {
        public void GuardarUsuario(Usuarios usuario)
        {
            using (var context = new AppDBContext())
            {
                context.Usuarios.Add(usuario);
                context.SaveChanges();
            }
        }

        public List<Usuarios> ObtenerUsuarios()
        {
            using (var context = new AppDBContext())
            {
                return context.Usuarios.ToList();
            }
        }

    }
}
