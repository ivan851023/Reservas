using Microsoft.EntityFrameworkCore;
using ReservaAPI.Entities;
using ReservaAPI.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservaAPI.Context
{
    public class dbContext : DbContext
    {
        public dbContext()
        {

        }

        public dbContext(DbContextOptions<dbContext> options)
              : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Hotel> Hoteles { get; set; }

        public DbSet<Reserva> Reservas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new HotelMap());
            modelBuilder.ApplyConfiguration(new ReservaMap());
        }


    }
}
