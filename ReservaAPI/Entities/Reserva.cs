using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservaAPI.Entities
{
    public class Reserva
    {
        public int Id { get; set; }

        public int Id_Usuario { get; set; }

        public int Id_Hotel { get; set; }

        public DateTime Fecha_Entrada { get; set; }

        public DateTime Fecha_Salida { get; set; }

        public DateTime Fecha_Reserva { get; set; }

        public string Estado { get; set; }

        public virtual Usuario Usuarios { get; set; }

        public virtual Hotel Hoteles { get; set; }

    }
}
