using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolManager.Business.Models;

namespace SchoolManager.Data.Mappings
{
    class EscolaMapping : IEntityTypeConfiguration<Escola>
    {
        public void Configure(EntityTypeBuilder<Escola> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Prefixo)
                .IsRequired()
                .HasColumnType("varchar(30)");

            builder.Property(s => s.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(s => s.Rua)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(s => s.Bairro)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(s => s.Numero)
                .IsRequired();

            builder.HasMany(p => p.Turmas)
                .WithOne(p => p.Escola)
                .HasForeignKey(p => p.EscolaId);

            builder.ToTable("Escolas");

        }
    }
}
