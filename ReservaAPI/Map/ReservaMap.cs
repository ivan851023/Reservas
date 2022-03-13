using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReservaAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservaAPI.Map
{
    public class ReservaMap : IEntityTypeConfiguration<Reserva>
    {
        public void Configure(EntityTypeBuilder<Reserva> entity)
        {
            entity.HasKey(e => e.Id);
            entity.ToTable("RESERVA");
            entity.HasIndex(e => e.Id);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Id_Hotel).HasColumnName("ID_HOTEL");
            entity.Property(e => e.Id_Usuario).HasColumnName("ID_USUARIO");
            entity.Property(e => e.Fecha_Entrada).HasColumnName("FECHA_ENTRADA");
            entity.Property(e => e.Fecha_Salida).HasColumnName("FECHA_SALIDA");
            entity.Property(e => e.Fecha_Reserva).HasColumnName("FECHA_RESERVA");
            entity.Property(e => e.Estado).HasColumnName("ESTADO");
            entity.HasOne(d => d.Usuarios)
                   .WithMany(p => p.Reservas)
                   .HasForeignKey(d => d.Id_Usuario)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("USUARIO_RESERVA_FK");
            entity.HasOne(d => d.Hoteles)
                   .WithMany(p => p.Reservas)
                   .HasForeignKey(d => d.Id_Hotel)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("HOTEL_RESERVA_FK");
        }
    }
}
