using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolManager.Business.Models;

namespace SchoolManager.Data.Mappings
{
    public class TurmaMapping : IEntityTypeConfiguration<Turma>
    {
        public void Configure(EntityTypeBuilder<Turma> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Curso)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(s => s.Serie)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(s => s.Turno)
                .IsRequired()
                .HasColumnType("varchar(10)");

            builder.Property(s => s.Vagas)
                .IsRequired();

            builder.ToTable("Turmas");
        }
    }
}
