using SchoolManager.Business.Models;
using System.Threading.Tasks;

namespace SchoolManager.Business.Interfaces
{
    public interface ITurmaService
    {
        Task<Turma> Adicionar(Turma turma);
    }
}
