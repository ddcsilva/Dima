using Dima.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dima.Api.Mappings;

public class TransacaoMapping : IEntityTypeConfiguration<Transacao>
{
    public void Configure(EntityTypeBuilder<Transacao> builder)
    {
        builder.ToTable("Transacao");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Titulo)
            .HasColumnType("NVARCHAR")
            .HasMaxLength(80)
            .IsRequired(true);

        builder.Property(x => x.Tipo)
            .HasColumnType("SMALLINT")
            .IsRequired(true);

        builder.Property(x => x.Valor)
            .HasColumnType("MONEY")
            .IsRequired(true);

        builder.Property(x => x.DataCriacao)
            .HasColumnType("DATETIME2")
            .IsRequired(true);

        builder.Property(x => x.DataRecebimento)
            .HasColumnType("DATETIME2")
            .IsRequired(false);

        builder.Property(x => x.UsuarioId)
            .HasColumnType("VARCHAR")
            .HasMaxLength(160)
            .IsRequired(true);
    }
}