using ReservaAPI.Entities;
using ReservaAPI.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservaAPI.Repository.DAL
{
    public class ReservaDAL : IReserva
    {
        private readonly IRepositoryBase<Reserva> _repository;
        public ReservaDAL(IRepositoryBase<Reserva> repository)
        {
            _repository = repository;
        }

        public void Insert(Reserva table)
        {   
            _repository.Insert(table);
        }

        public Reserva GetById(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<Reserva> GetReservas()
        {
            return _repository.GetAll();
        }

        public void Update(Reserva table)
        {
            _repository.Update(table);
        }
    }
}
