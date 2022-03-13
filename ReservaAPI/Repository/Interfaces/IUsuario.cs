using ReservaAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservaAPI.Repository.Interfaces
{
   public interface IUsuario
    {
        void Insert(Usuario entity);

        Usuario GetById(int id);

        IEnumerable<Usuario> GetUsuarios();
    }
}
