using ReservaAPI.Entities;
using ReservaAPI.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservaAPI.Repository.DAL
{
    public class HotelDAL : IHotel
    {
        private readonly IRepositoryBase<Hotel> _repository;
        public HotelDAL(IRepositoryBase<Hotel> repository)
        {
            _repository = repository;
        }

        public void Insert(Hotel table)
        {   
            _repository.Insert(table);
        }

        public Hotel GetById(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<Hotel> GetHoteles()
        {
            return _repository.GetAll();
        }
    }
}
