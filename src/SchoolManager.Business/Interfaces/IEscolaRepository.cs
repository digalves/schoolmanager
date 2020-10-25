using SchoolManager.Business.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolManager.Business.Interfaces
{
    public interface IEscolaRepository : IRepository<Escola>
    {
        Task<ICollection<Escola>> ObterEscolasTurmas();
    }
}
