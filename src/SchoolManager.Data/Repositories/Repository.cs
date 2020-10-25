using Microsoft.EntityFrameworkCore;
using SchoolManager.Business.Interfaces;
using SchoolManager.Business.Models;
using SchoolManager.Data.Context;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Data.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : Entity, new()
    {

        protected readonly SchoolManagerDbContext DbContext;
        protected readonly DbSet<T> DbSet;

        public Repository(SchoolManagerDbContext context)
        {
            DbContext = context;
            DbSet = context.Set<T>();
        }

        public virtual async Task<List<T>> ObterTodas()
        {
            return await DbSet.ToListAsync();
        }

        public virtual async Task Adicionar(T entity)
        {
            DbSet.Add(entity);
            await Salvar();
        }

        public async Task<int> Salvar()
        {
            return await DbContext.SaveChangesAsync();
        }

        public async Task<T> ObterPorId(Guid id)
        {
            return await DbSet.FindAsync(id);
        }
    }
}
