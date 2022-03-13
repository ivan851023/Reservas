using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservaAPI.Models
{
    public class ReservaModel
    {
        public string Id_Usuario { get; set; }

        public string Id_Hotel { get; set; }

        public string Fecha_Entrada { get; set; }

        public string Fecha_Salida { get; set; }

        public string Fecha_Reserva { get; set; }

        public string Estado { get; set; }

        public string IdReserva { get; set; }

        public string NombreHotel { get; set; }

        public string EmailUsuario { get; set; }
    }
}
