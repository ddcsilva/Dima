using Dima.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dima.Api.Mappings;

public class CategoriaMapping : IEntityTypeConfiguration<Categoria>
{
    public void Configure(EntityTypeBuilder<Categoria> builder)
    {
        builder.ToTable("Categoria");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Titulo)
            .HasColumnType("NVARCHAR")
            .HasMaxLength(80)
            .IsRequired();

        builder.Property(x => x.Descricao)
            .HasColumnType("NVARCHAR")
            .HasMaxLength(80)
            .IsRequired(false);

        builder.Property(x => x.UsuarioId)
            .HasColumnType("NVARCHAR")
            .HasMaxLength(160)
            .IsRequired(true);
    }
}