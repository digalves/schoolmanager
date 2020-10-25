using Microsoft.EntityFrameworkCore;
using SchoolManager.Business.Models;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SchoolManager.Data.Context
{
    public class SchoolManagerDbContext : DbContext
    {

        public SchoolManagerDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Escola> Escolas { get; set; }
        public DbSet<Turma> Turmas { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
