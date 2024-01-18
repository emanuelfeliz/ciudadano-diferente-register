using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CiudadanoDiferente.Models;

public partial class CiudadanoDiferenteContext : DbContext
{
    public CiudadanoDiferenteContext()
    {
    }

    public CiudadanoDiferenteContext(DbContextOptions<CiudadanoDiferenteContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Miembro> Miembros { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { 
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        //=> optionsBuilder.UseSqlServer("server=localhost; database=CiudadanoDiferente; integrated security=true; TrustServerCertificate=Yes");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Miembro>(entity =>
        {
            entity.HasKey(e => e.VotanteId).HasName("PK__Votantes__3DCA8F042EEAC0E9");

            entity.HasIndex(e => e.Cedula, "UQ__Votantes__B4ADFE38B24B33F3").IsUnique();

            entity.Property(e => e.VotanteId).HasColumnName("VotanteID");
            entity.Property(e => e.Cedula).HasMaxLength(20);
            entity.Property(e => e.ColegioElectoral).HasMaxLength(50);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Recinto).HasMaxLength(50);
            entity.Property(e => e.Telefono).HasMaxLength(15);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
