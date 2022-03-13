using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservaAPI.Entities
{
    public class Hotel
    {
        public Hotel()
        {

        }

        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Pais { get; set; }

        public int Latitud { get; set; }

        public int Longitud { get; set; }

        public string Descripcion { get; set; }

        public bool Activo { get; set; }

        public ICollection<Reserva> Reservas;

    }
}
