using Core.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using SchoolManager.Business.Interfaces;
using SchoolManager.Business.Models;
using SchoolManager.Data.Context;
using System;
using System.Threading.Tasks;

namespace SchoolManager.Data.Repositories
{
    public class TurmaRepository : Repository<Turma>, ITurmaRepository
    {
        public TurmaRepository(SchoolManagerDbContext context) : base(context)
        {
        }

        public Task<Turma> ObterTurmaEscola(Guid id)
        {
            return DbContext.Turmas.AsNoTracking()
                .Include(s => s.Escola)
                .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
