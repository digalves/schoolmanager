using Core.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using SchoolManager.Business.Interfaces;
using SchoolManager.Business.Models;
using SchoolManager.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManager.Data.Repositories
{
    public class TurmaRepository : Repository<Turma>, ITurmaRepository
    {
        public TurmaRepository(SchoolManagerDbContext context) : base(context)
        {
        }

        public async Task<Turma> ObterTurmaEscola(Guid id)
        {
            return await DbContext.Turmas
               .Include(s => s.Escola)
               .Where(p => p.EscolaId == id)
               .AsNoTracking()
               .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Turma>> ObterTurmasEscola(Guid id)
        {
            return await DbContext.Turmas
                .Include(s => s.Escola)
                .Where(p => p.EscolaId == id)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
