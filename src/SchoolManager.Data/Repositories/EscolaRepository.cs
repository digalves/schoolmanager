using Core.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using SchoolManager.Business.Interfaces;
using SchoolManager.Business.Models;
using SchoolManager.Data.Context;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolManager.Data.Repositories
{
    public class EscolaRepository : Repository<Escola>, IEscolaRepository
    {
        public EscolaRepository(SchoolManagerDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Escola>> ObterEscolasTurmas()
        {
            return await DbContext.Escolas.AsNoTracking()
                .Include(p => p.Turmas).ToListAsync();
        }
    }
}
