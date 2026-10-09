using ACTIVIDAD.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACTIVIDAD.Data
{
    public class DatosSala
    {
        public void GuardarSala(Salas salas)
        {
            using (var context = new AppDBContext())
            {
                context.Salas.Add(salas);
                context.SaveChanges();
            }

        }

        public List<Salas> ObtenerSalas()
        {
            using (var context = new AppDBContext())
            {
                return context.Salas.ToList();
            }
        }
    }
}
