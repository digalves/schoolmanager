using SchoolManager.Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolManager.Business.Interfaces
{
    public interface ITurmaRepository : IRepository<Turma>
    {
        Task<IEnumerable<Turma>> ObterTurmasEscola(Guid id);
        Task<Turma> ObterTurmaEscola(Guid id);
    }
}
