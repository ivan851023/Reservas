using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservaAPI.Entities
{
    public class Usuario
    {
        public Usuario()
        {

        }
        
        public int Id { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string Email { get; set; }

        public string Direccion { get; set; }

        public ICollection<Reserva> Reservas;
    }

}