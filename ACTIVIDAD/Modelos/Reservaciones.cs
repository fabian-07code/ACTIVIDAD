using System;
using System.Collections.Generic;
using System.Text;

namespace ACTIVIDAD.Modelos
{
    public class Reservaciones
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdSala { get; set; }
        public DateTime FechaReservacion { get; set; }
        
    }
}
