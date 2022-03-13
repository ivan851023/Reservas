using ReservaAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservaAPI.Repository.Interfaces
{
   public interface IHotel
    {
        void Insert(Hotel entity);

        Hotel GetById(int id);

        IEnumerable<Hotel> GetHoteles();
    }
}
