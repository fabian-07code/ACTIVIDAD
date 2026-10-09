using System;
using System.Collections.Generic;
using System.Text;

namespace ACTIVIDAD.Modelos
{
    public class Usuarios
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Departamento { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
    }
}
