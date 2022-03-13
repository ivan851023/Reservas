using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReservaAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservaAPI.Map
{
    public class HotelMap : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> entity)
        {
            entity.HasKey(e => e.Id);
            entity.ToTable("HOTEL");
            entity.HasIndex(e => e.Id);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Nombre).HasColumnName("NOMBRE");
            entity.Property(e => e.Pais).HasColumnName("PAIS");
            entity.Property(e => e.Latitud).HasColumnName("LATITUD");
            entity.Property(e => e.Longitud).HasColumnName("LONGITUD");
            entity.Property(e => e.Descripcion).HasColumnName("DESCRIPCION");
            entity.Property(e => e.Activo).HasColumnName("ACTIVO");
        }

    }
}
