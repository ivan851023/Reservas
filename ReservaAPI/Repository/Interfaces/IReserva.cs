using ReservaAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservaAPI.Repository.Interfaces
{
    public interface IReserva
    {
        void Insert(Reserva entity);

        void Update(Reserva entity);

        Reserva GetById(int id);

        IEnumerable<Reserva> GetReservas();
    }
}
