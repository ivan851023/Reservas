﻿using ReservaAPI.Entities;
using ReservaAPI.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservaAPI.Repository.DAL
{
    public class UsuarioDAL : IUsuario
    {
        private readonly IRepositoryBase<Usuario> _repository;
        public UsuarioDAL(IRepositoryBase<Usuario> repository)
        {
            _repository = repository;
        }

        public void Insert(Usuario table)
        {   
            _repository.Insert(table);
        }

        public Usuario GetById(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<Usuario> GetUsuarios()
        {
            return _repository.GetAll();
        }
    }
}
