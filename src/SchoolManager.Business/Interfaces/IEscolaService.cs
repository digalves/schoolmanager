using SchoolManager.Business.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolManager.Business.Interfaces
{
    public interface IEscolaService
    {
        Task<Escola> Adicionar(Escola escola);
    }
}
