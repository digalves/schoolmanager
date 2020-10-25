using SchoolManager.Business.Models;
using System;
using System.Threading.Tasks;

namespace SchoolManager.Business.Interfaces
{
    public interface ITurmaRepository : IRepository<Turma>
    {
        Task<Turma> ObterTurmaEscola(Guid id);
    }
}
